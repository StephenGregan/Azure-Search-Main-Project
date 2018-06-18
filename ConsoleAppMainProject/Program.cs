using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static ConsoleAppMainProject.Json;

namespace ConsoleAppMainProject
{
    class Program
    {
        static void Main()
        {
            var mainJson = LoginAndDeserailizeJson();
        }

        static string LoginAndDeserailizeJson()
        {
            using (var client = new WebClientEx())
            {
                var values = new NameValueCollection
                {
                    { "j_username", "[username]" },
                    { "j_password", "[password]"},
                };
                Console.WriteLine("Trying to validate username and password.....\n");

                client.UploadValues("https://tie.interpreterintelligence.com/j_spring_security_check", values);

                Console.WriteLine("Successfully logged in to ii.....\n");
                
                var json = client.DownloadString("https://tie.interpreterintelligence.com:443/api/contact");

                Console.WriteLine("Deserialized json : " + json);

                var rootjson = JsonConvert.DeserializeObject<dynamic>(json);

                Console.WriteLine("Root object : " + rootjson);

                //File.WriteAllText(@"", JsonConvert.SerializeObject());

                return json;
            } 
        }
    }
}
