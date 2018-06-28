using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleAppMainProject;
//using static ConsoleAppMainProject.Json;

namespace ConsoleAppMainProject
{
    class Program
    {
        private const string InterpreterIntelligenceIndex = "interpreterintelligencecontacts-index";
        private const string InterpreterIntelligenceDataSource = "interpreterintelligencecontacts-datasource";
        private const string InterpreterIntelligenceIndexer = "interpreterintelligencecontacts-indexer";

        private static ISearchServiceClient _searchClient;
        private static ISearchIndexClient _indexClient;

        static void Main(String [] args)
        {
            LoginAndDeserailizeJson();

            string searchServiceName = ConfigurationManager.AppSettings["SearchServiceName"];
            string apiKey = ConfigurationManager.AppSettings["SearchServiceApiKey"];

            // Create an HTTP reference to the catalog index
            _searchClient = new SearchServiceClient(searchServiceName, new SearchCredentials(apiKey));
            _indexClient = _searchClient.Indexes.GetClient(InterpreterIntelligenceIndex);

            Console.WriteLine("{0}", "Deleting index, data source, and indexer...\n");
            if (DeleteIndexingResources())
            {
                Console.WriteLine("{0}", "Creating index...\n");
                CreateIndex();
                Console.WriteLine("{0}", "Sync documents from Blob Storage...\n");
                SyncDataFromBlobSorage();
            }
            Console.WriteLine("{0}", "Complete.  Press any key to end application...\n");

            Console.ReadKey();
        }

        private static void SyncDataFromBlobSorage()
        {
            // This will use the Azure Search Indexer to synchronize data from Blob Storage to Azure Search
            Console.WriteLine("{0}", "Creating Data Source...\n");
            var dataSource =
                DataSource.AzureBlobStorage(
                    name: InterpreterIntelligenceDataSource,
                    storageConnectionString: 
                    containerName: "");

            try
            {
                _searchClient.DataSources.Create(dataSource);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating data source: {0}", ex.Message);
                return;
            }

            Console.WriteLine("{0}", "Creating Indexer and syncing data...\n");

            var indexer =
                new Indexer()
                {
                    Name = InterpreterIntelligenceIndexer,
                    Description = "Interpreter Intelligence indexer",
                    DataSourceName = dataSource.Name,
                    TargetIndexName = InterpreterIntelligenceIndex
                };

            try
            {
                _searchClient.Indexers.Create(indexer);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating and running indexer: {0}", ex.Message);
                return;
            }

            bool running = true;
            Console.WriteLine("{0}", "Synchronization running...\n");
            while (running)
            {
                IndexerExecutionInfo status = null;

                try
                {
                    status = _searchClient.Indexers.GetStatus(indexer.Name);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error polling for indexer status: {0}", ex.Message);
                    return;
                }

                IndexerExecutionResult lastResult = status.LastResult;
                if (lastResult != null)
                {
                    switch (lastResult.Status)
                    {
                        case IndexerExecutionStatus.InProgress:
                            Console.WriteLine("{0}", "Synchronization running...\n");
                            Thread.Sleep(1000);
                            break;

                        case IndexerExecutionStatus.Success:
                            running = false;
                            Console.WriteLine("Synchronized {0} rows...\n", lastResult.ItemCount);
                            break;

                        default:
                            running = false;
                            Console.WriteLine("Synchronization failed: {0}\n", lastResult.ErrorMessage);
                            break;
                    }
                }
            }
        }



        private static void CreateIndex()
        {
            // Create the Azure Search index based on the included schema
            try
            {
                var definition = new Index()
                {
                    Name = InterpreterIntelligenceIndex,
                    Fields = FieldBuilder.BuildForType<Welcome>()
                
                //Name = InterpreterIntelligenceIndex,
                //Fields = new[]
                //{
                //    new Field("page",     DataType.Int32)                { IsKey = false,  IsSearchable = false, IsFilterable = true, IsSortable = true, IsFacetable = true, IsRetrievable = true},
                //    new Field("total",   DataType.Int32)                 { IsKey = false, IsSearchable = false,  IsFilterable = true,  IsSortable = true,  IsFacetable = false, IsRetrievable = true},
                //    new Field("records",  DataType.Int32)                { IsKey = false, IsSearchable = false,  IsFilterable = true,  IsSortable = true,  IsFacetable = false, IsRetrievable = true},
                //    new Field("id",    DataType.String)                  { IsKey = true, IsSearchable = false,  IsFilterable = false,  IsSortable = false,  IsFacetable = false, IsRetrievable = true}
                //new Field("STATE_NUMERIC",  DataType.Int32)          { IsKey = false, IsSearchable = false, IsFilterable = true,  IsSortable = true,  IsFacetable = true,  IsRetrievable = true},
                //new Field("COUNTY_NAME",    DataType.String)         { IsKey = false, IsSearchable = true,  IsFilterable = true,  IsSortable = true,  IsFacetable = false, IsRetrievable = true},
                //new Field("COUNTY_NUMERIC", DataType.Int32)          { IsKey = false, IsSearchable = false, IsFilterable = true,  IsSortable = true,  IsFacetable = true,  IsRetrievable = true},
                //new Field("ELEV_IN_M",      DataType.Int32)          { IsKey = false, IsSearchable = false, IsFilterable = true,  IsSortable = true,  IsFacetable = true,  IsRetrievable = true},
                //new Field("ELEV_IN_FT",     DataType.Int32)          { IsKey = false, IsSearchable = false, IsFilterable = true,  IsSortable = true,  IsFacetable = true,  IsRetrievable = true},
                //new Field("MAP_NAME",       DataType.String)         { IsKey = false, IsSearchable = true,  IsFilterable = true,  IsSortable = true,  IsFacetable = false, IsRetrievable = true},
                //new Field("DESCRIPTION",    DataType.String)         { IsKey = false, IsSearchable = true,  IsFilterable = false, IsSortable = false, IsFacetable = false, IsRetrievable = true},
                //new Field("HISTORY",        DataType.String)         { IsKey = false, IsSearchable = true,  IsFilterable = false, IsSortable = false, IsFacetable = false, IsRetrievable = true},
                //new Field("DATE_CREATED",   DataType.DateTimeOffset) { IsKey = false, IsSearchable = false, IsFilterable = true,  IsSortable = true,  IsFacetable = true,  IsRetrievable = true},
                //new Field("DATE_EDITED",    DataType.DateTimeOffset) { IsKey = false, IsSearchable = false, IsFilterable = true,  IsSortable = true,  IsFacetable = true,  IsRetrievable = true}
                //}
                };

                _searchClient.Indexes.Create(definition);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating index: {0}\r\n", ex.Message);
            }
        }

        private static bool DeleteIndexingResources()
        {
            // Delete the index, data source, and indexer.
            try
            {
                _searchClient.Indexes.Delete(InterpreterIntelligenceIndex);
                _searchClient.DataSources.Delete(InterpreterIntelligenceDataSource);
                _searchClient.Indexers.Delete(InterpreterIntelligenceIndexer);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting indexing resources: {0}\r\n", ex.Message);
                Console.WriteLine("Did you remember to add your SearchServiceName and SearchServiceApiKey to the app.config?\r\n");
                return false;
            }

            return true;
        }

        static string LoginAndDeserailizeJson()
        {
            using (var client = new WebClientEx())
            {
                var values = new NameValueCollection
                {
                    { "j_username", "" },
                    { "j_password", "" },
                };
                Console.WriteLine("Trying to validate username and password.....\n");

                client.UploadValues("https://tie.interpreterintelligence.com/j_spring_security_check", values);

                Console.WriteLine("Successfully logged in to ii.....\n");
                
                var json = client.DownloadString("https://tie.interpreterintelligence.com:443/api/contact");

                Console.WriteLine("Download string from Interpreter Intelligence : " + json);

                dynamic rootjson = JsonConvert.DeserializeObject(json);

                //var rootjson = JsonConvert.DeserializeObject<dynamic>(json);

                Console.WriteLine("Root object : " + rootjson);

                File.WriteAllText(@"C:\Users\Ronan\Json\stephengregan.json", JsonConvert.SerializeObject(rootjson));

                Console.WriteLine("Contents successfully writing to file.....");

                return json;
            }
        }
    }
}
