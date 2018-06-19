////using Microsoft.Azure.Search;
////using Microsoft.Azure.Search.Models;
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace ConsoleAppMainProject
////{
////    [SerializePropertyNamesAsCamelCase]
////    class Json
////    {
////        [SerializePropertyNamesAsCamelCase]
////        public class Rootobject
////        {
////            [IsFilterable, IsSortable, IsFacetable]
////            public int page { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int total { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int records { get; set; }
////            [IsSearchable, IsFilterable, IsFacetable]
////            public Row[] rows { get; set; }
////        }
////        [SerializePropertyNamesAsCamelCase]
////        public class Row
////        {
////            [IsFilterable, IsSortable, IsFacetable]
////            public int id { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int versionValue { get; set; }
////            [System.ComponentModel.DataAnnotations.Key]
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string uuid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string createdBy { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string createdDate { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string lastModifiedBy { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string lastModifiedDate { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int companyid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string name { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string displayName { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string salutation { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string firstName { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string middleName { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string lastName { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string nickName { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string suffix { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int genderid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string businessUnitid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string dateOfBirth { get; set; }
////            [IsSearchable, IsFilterable, IsFacetable]
////            public object[] contactTypes { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string accountingReference { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string referenceId { get; set; }
////            [IsSearchable, IsFilterable, IsFacetable]
////            public Languagemapping[] languageMappings { get; set; }
////            [IsSearchable, IsFilterable, IsFacetable]
////            public Primarynumber primaryNumber { get; set; }
////            [IsSearchable, IsFilterable, IsFacetable]
////            public Number[] numbers { get; set; }
////            [IsSearchable, IsFilterable, IsFacetable]
////            public Primaryaddress primaryAddress { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public float lat { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public float lng { get; set; }
////            [IsSearchable, IsFilterable, IsFacetable]
////            public Address[] addresses { get; set; }
////            [IsSearchable, IsFilterable, IsFacetable]
////            public Primaryemail primaryEmail { get; set; }
////            [IsSearchable, IsFilterable, IsFacetable]
////            public Email[] emails { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool? hasTransportation { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool? hasChildren { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string notes { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object companyName { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object website { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object region { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string countryOfOrigin { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string countryOfResidence { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string countryOfNationality { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string active { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string activeNote { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string availability { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string experience { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string registeredTaxId { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string bankAccount { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string sortCode { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string iban { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string swift { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string eftid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string eftname { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object paymentMethodid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string paymentMethodname { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool registeredTax { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object registeredTaxIdDescription { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int employmentCategoryid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string employmentCategorydescription { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int assignmentTierid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string timeZone { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string ethnicity { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object document { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string imagePath { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool outOfOffice { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object disableUpcomingReminder { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object disableCloseReminder { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object disableConfirmReminder { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object bankAccountDescription { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string timeWorked { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object activationDate { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object originalStartDate { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object datePhotoSentToPrinter { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object datePhotoSentToInterpreter { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object inductionDate { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object reActivationDate { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object iolNrcpdNumber { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object referralSource { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object refereeSourceName { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object recruiterName { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object taleoId { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object bankAccountReference { get; set; }
////            public Status status { get; set; }
////            public Ratesummary rateSummary { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string distance { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int? rating { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int? languagesId { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string language { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string languageCode { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string moreLanguages { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string employmentEligibilityStatus { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string number { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string address { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string email { get; set; }
////        }

////        [SerializePropertyNamesAsCamelCase]
////        public class Primarynumber
////        {
////            [IsFilterable, IsSortable, IsFacetable]
////            public int id { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string parsedNumber { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object numberFormatted { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object countryCode { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object areaCode { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object number { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int typeid { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool primaryNumber { get; set; }
////        }

////        [SerializePropertyNamesAsCamelCase]
////        public class Primaryaddress
////        {
////            [IsFilterable, IsSortable, IsFacetable]
////            public int id { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string clientid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object clientLabel { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int companyid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string customerid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string customerBillingid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string displayLabel { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string description { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object notes { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string addrEntered { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string addrFormatted { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string aptUnit { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string preamble { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string street1 { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object street2 { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object street3 { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string cityTown { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string stateCounty { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string postalCode { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object country { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool primaryAddress { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool valid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string validationStatus { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool validated { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int typeid { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public float lat { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public float lng { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object addressPhone { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object addressFax { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object addressEmail { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object contactPerson { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object costCenter { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool active { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string parentid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string parentlabel { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object publicNotes { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string regionid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string billingRegionid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object costCenterName { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object timeZone { get; set; }
////        }

////        [SerializePropertyNamesAsCamelCase]
////        public class Primaryemail
////        {
////            [IsFilterable, IsSortable, IsFacetable]
////            public int id { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string emailAddress { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object addressVerified { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object dateVerified { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool primaryEmail { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int typeid { get; set; }
////        }

////        [SerializePropertyNamesAsCamelCase]
////        public class Status
////        {
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string _class { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int id { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool defaultOption { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string description { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object l10nKey { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string name { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string nameKey { get; set; }
////        }

////        [SerializePropertyNamesAsCamelCase]
////        public class Ratesummary
////        {
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string inperson { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string phone { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string video { get; set; }
////        }

////        [SerializePropertyNamesAsCamelCase]
////        public class Languagemapping
////        {
////            [IsFilterable, IsSortable, IsFacetable]
////            public int id { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int contactid { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int languageid { get; set; }
////            [IsSearchable, IsFilterable, IsFacetable]
////            public Language language { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string rating { get; set; }
////        }

////        [SerializePropertyNamesAsCamelCase]
////        public class Language
////        {
////            [IsFilterable, IsSortable, IsFacetable]
////            public int id { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string label { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string description { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string alternates { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string value { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string subtag { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string iso639_3Tag { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string type { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string alias { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool enabled { get; set; }
////        }

////        [SerializePropertyNamesAsCamelCase]
////        public class Number
////        {
////            [IsFilterable, IsSortable, IsFacetable]
////            public int id { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string parsedNumber { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object numberFormatted { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object countryCode { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object areaCode { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object number { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int typeid { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool primaryNumber { get; set; }
////        }

////        [SerializePropertyNamesAsCamelCase]
////        public class Address
////        {
////            [IsFilterable, IsSortable, IsFacetable]
////            public int id { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string clientid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object clientLabel { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int companyid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string customerid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string customerBillingid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string displayLabel { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string description { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object notes { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string addrEntered { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string addrFormatted { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string aptUnit { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string preamble { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string street1 { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object street2 { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object street3 { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string cityTown { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string stateCounty { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string postalCode { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object country { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool primaryAddress { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool valid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string validationStatus { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool validated { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int typeid { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public float lat { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public float lng { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object addressPhone { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object addressFax { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object addressEmail { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object contactPerson { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object costCenter { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool active { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string parentid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string parentlabel { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object publicNotes { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string regionid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string billingRegionid { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object costCenterName { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object timeZone { get; set; }
////        }

////        [SerializePropertyNamesAsCamelCase]
////        public class Email
////        {
////            [IsFilterable, IsSortable, IsFacetable]
////            public int id { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public string emailAddress { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object addressVerified { get; set; }
////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////            public object dateVerified { get; set; }
////            [IsFilterable, IsFacetable]
////            public bool primaryEmail { get; set; }
////            [IsFilterable, IsSortable, IsFacetable]
////            public int typeid { get; set; }
////        }
////    }
////}
//// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
////
////    using ConsoleAppTestStephenGregan;
////
////    var welcome = Welcome.FromJson(jsonString);
//namespace ConsoleAppMainProject
//{
//    using System;
//    using System.Collections.Generic;

//    using System.Globalization;
//    using Microsoft.Azure.Search;
//    using Microsoft.Azure.Search.Models;
//    using Newtonsoft.Json;
//    using Newtonsoft.Json.Converters;

//    [SerializePropertyNamesAsCamelCase]
//    public partial class Welcome
//    {
//        [IsFilterable, IsSortable, IsFacetable]
//        public long Page { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long Total { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long Records { get; set; }

//        //[IsSearchable, IsFilterable, IsFacetable]
//        //public Row[] Rows { get; set; }

//    }

//    public partial class Row
//    {
//        [IsFilterable, IsSortable, IsFacetable]
//        public long Id { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long VersionValue { get; set; }

//        [System.ComponentModel.DataAnnotations.Key]
//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Uuid { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string CreatedBy { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string CreatedDate { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string LastModifiedBy { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string LastModifiedDate { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long CompanyId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Name { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string DisplayName { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId Salutation { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string FirstName { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string MiddleName { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string LastName { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId NickName { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId Suffix { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long GenderId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId BusinessUnitId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string DateOfBirth { get; set; }

//        //[IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        //public object[] ContactTypes { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        [JsonConverter(typeof(ParseIntegerConverter))]
//        public long AccountingReference { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        [JsonConverter(typeof(ParseIntegerConverter))]
//        public long ReferenceId { get; set; }

//        //[IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        //public LanguageMapping[] LanguageMappings { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Number PrimaryNumber { get; set; }

//        //[IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        //public Number[] Numbers { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Address PrimaryAddress { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public double Lat { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public double Lng { get; set; }

//        //[IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        //public Address[] Addresses { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Email PrimaryEmail { get; set; }

//        //[IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        //public Email[] Emails { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool? HasTransportation { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool? HasChildren { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Notes { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object CompanyName { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object Website { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object Region { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string CountryOfOrigin { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public CountryOfResidence? CountryOfResidence { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string CountryOfNationality { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Active Active { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string ActiveNote { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Availability { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Experience { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string RegisteredTaxId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string BankAccount { get; set; }

//        [JsonConverter(typeof(ParseIntegerConverter))]
//        public long? SortCode { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Iban { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Swift { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId EftId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId EftName { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public PaymentMethodId PaymentMethodId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public PaymentMethodName PaymentMethodName { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool RegisteredTax { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string RegisteredTaxIdDescription { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long EmploymentCategoryId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public EmploymentCategoryDescription EmploymentCategoryDescription { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long AssignmentTierId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId TimeZone { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId Ethnicity { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object Document { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public ImagePath ImagePath { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool OutOfOffice { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object DisableUpcomingReminder { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object DisableCloseReminder { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object DisableConfirmReminder { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object BankAccountDescription { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string TimeWorked { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object ActivationDate { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object OriginalStartDate { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object DatePhotoSentToPrinter { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object DatePhotoSentToInterpreter { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object InductionDate { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object ReActivationDate { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object IolNrcpdNumber { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object ReferralSource { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object RefereeSourceName { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object RecruiterName { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object TaleoId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object BankAccountReference { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Status Status { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public RateSummary RateSummary { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Distance Distance { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long? Rating { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long? LanguagesId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Language { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string LanguageCode { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public MoreLanguages MoreLanguages { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public EmploymentEligibilityStatus EmploymentEligibilityStatus { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Number { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Address { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Email { get; set; }
//    }

//    public partial class Address
//    {
//        [IsFilterable, IsSortable, IsFacetable]
//        public long Id { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId ClientId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object ClientLabel { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long CompanyId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId CustomerId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId CustomerBillingId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string DisplayLabel { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Description { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object Notes { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string AddrEntered { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string AddrFormatted { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string AptUnit { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object Preamble { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Street1 { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object Street2 { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object Street3 { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string CityTown { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public StateCounty StateCounty { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string PostalCode { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object Country { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool PrimaryAddress { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool Valid { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public ValidationStatus ValidationStatus { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool Validated { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long TypeId { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public double Lat { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public double Lng { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object AddressPhone { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object AddressFax { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object AddressEmail { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object ContactPerson { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object CostCenter { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool Active { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId ParentId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId ParentLabel { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object PublicNotes { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId RegionId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public BusinessUnitId BillingRegionId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object CostCenterName { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object TimeZone { get; set; }
//    }

//    public partial class Email
//    {
//        [IsFilterable, IsSortable, IsFacetable]
//        public long Id { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string EmailAddress { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object AddressVerified { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object DateVerified { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool PrimaryEmail { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long TypeId { get; set; }
//    }

//    public partial class LanguageMapping
//    {
//        [IsFilterable, IsSortable, IsFacetable]
//        public long Id { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long ContactId { get; set; }

//        public long LanguageId { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Language Language { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        [JsonConverter(typeof(ParseIntegerConverter))]
//        public long Rating { get; set; }
//    }

//    public partial class Language
//    {
//        [IsFilterable, IsSortable, IsFacetable]
//        public long Id { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Label { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Description { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Alternates { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Value { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Subtag { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Iso6393Tag { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public TypeEnum Type { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string Alias { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool Enabled { get; set; }
//    }

//    public partial class Number
//    {
//        [IsFilterable, IsSortable, IsFacetable]
//        public long Id { get; set; }

//        [System.ComponentModel.DataAnnotations.Key]
//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public string ParsedNumber { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object NumberFormatted { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object CountryCode { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object AreaCode { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object NumberNumber { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long TypeId { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool PrimaryNumber { get; set; }
//    }

//    public partial class RateSummary
//    {
//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Inperson Inperson { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Inperson Phone { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Inperson Video { get; set; }
//    }

//    public partial class Status
//    {
//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Class Class { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public long Id { get; set; }

//        [IsFilterable, IsSortable, IsFacetable]
//        public bool DefaultOption { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Description Description { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public object L10NKey { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public Description Name { get; set; }

//        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//        public NameKey NameKey { get; set; }
//    }

//    public enum Active { Y };

//    public enum BusinessUnitId { Empty };

//    public enum StateCounty { CountyCork, CountyDublin, CountyKildare, CountyWexford };

//    public enum ValidationStatus { Ok, OkMultipleResults, OkPartial };

//    public enum CountryOfResidence { Fra, Irl };

//    public enum Distance { NA };

//    public enum EmploymentCategoryDescription { PreferredContractor, Vendor };

//    public enum EmploymentEligibilityStatus { Pass };

//    public enum ImagePath { HttpsTieInterpreterintelligenceComImagesPlaceholderPng };

//    public enum TypeEnum { Language };

//    public enum MoreLanguages { Empty, The1, The3, The4 };

//    public enum PaymentMethodName { Eft, Empty, Overseas };

//    public enum Inperson { SummaryUnavailable };

//    public enum Class { ComNgsIdModelTypeActiveContactStatus, ComNgsIdModelTypeInactiveStatus };

//    public enum Description { Active, Inactive };

//    public enum NameKey { Active, Inactive };

//    public partial struct PaymentMethodId
//    {
//        public BusinessUnitId? Enum;
//        public long? Integer;

//        public bool IsNull => Integer == null && Enum == null;
//    }


//    public partial class Welcome
//    {
//        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, ConsoleAppMainProject.Converter.Settings);
//    }

//    public static class Serialize
//    {
//        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, ConsoleAppMainProject.Converter.Settings);
//    }

//    internal static class Converter
//    {
//        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//        {
//            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//            DateParseHandling = DateParseHandling.None,
//            Converters = {
//                ActiveConverter.Singleton,
//                BusinessUnitIdConverter.Singleton,
//                StateCountyConverter.Singleton,
//                ValidationStatusConverter.Singleton,
//                CountryOfResidenceConverter.Singleton,
//                DistanceConverter.Singleton,
//                EmploymentCategoryDescriptionConverter.Singleton,
//                EmploymentEligibilityStatusConverter.Singleton,
//                ImagePathConverter.Singleton,
//                TypeEnumConverter.Singleton,
//                MoreLanguagesConverter.Singleton,
//                PaymentMethodIdConverter.Singleton,
//                PaymentMethodNameConverter.Singleton,
//                InpersonConverter.Singleton,
//                ClassConverter.Singleton,
//                DescriptionConverter.Singleton,
//                NameKeyConverter.Singleton,
//                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
//            },
//        };
//    }

//    internal class ParseIntegerConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            long l;
//            if (Int64.TryParse(value, out l))
//            {
//                return l;
//            }
//            throw new Exception("Cannot unmarshal type long");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (long)untypedValue;
//            serializer.Serialize(writer, value.ToString());
//            return;
//        }

//        public static readonly ParseIntegerConverter Singleton = new ParseIntegerConverter();
//    }

//    internal class ActiveConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(Active) || t == typeof(Active?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "Y")
//            {
//                return Active.Y;
//            }
//            throw new Exception("Cannot unmarshal type Active");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (Active)untypedValue;
//            if (value == Active.Y)
//            {
//                serializer.Serialize(writer, "Y");
//                return;
//            }
//            throw new Exception("Cannot marshal type Active");
//        }

//        public static readonly ActiveConverter Singleton = new ActiveConverter();
//    }

//    internal class BusinessUnitIdConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(BusinessUnitId) || t == typeof(BusinessUnitId?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "")
//            {
//                return BusinessUnitId.Empty;
//            }
//            throw new Exception("Cannot unmarshal type BusinessUnitId");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (BusinessUnitId)untypedValue;
//            if (value == BusinessUnitId.Empty)
//            {
//                serializer.Serialize(writer, "");
//                return;
//            }
//            throw new Exception("Cannot marshal type BusinessUnitId");
//        }

//        public static readonly BusinessUnitIdConverter Singleton = new BusinessUnitIdConverter();
//    }

//    internal class StateCountyConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(StateCounty) || t == typeof(StateCounty?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "County Cork":
//                    return StateCounty.CountyCork;
//                case "County Dublin":
//                    return StateCounty.CountyDublin;
//                case "County Kildare":
//                    return StateCounty.CountyKildare;
//                case "County Wexford":
//                    return StateCounty.CountyWexford;
//            }
//            throw new Exception("Cannot unmarshal type StateCounty");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (StateCounty)untypedValue;
//            switch (value)
//            {
//                case StateCounty.CountyCork:
//                    serializer.Serialize(writer, "County Cork");
//                    return;
//                case StateCounty.CountyDublin:
//                    serializer.Serialize(writer, "County Dublin");
//                    return;
//                case StateCounty.CountyKildare:
//                    serializer.Serialize(writer, "County Kildare");
//                    return;
//                case StateCounty.CountyWexford:
//                    serializer.Serialize(writer, "County Wexford");
//                    return;
//            }
//            throw new Exception("Cannot marshal type StateCounty");
//        }

//        public static readonly StateCountyConverter Singleton = new StateCountyConverter();
//    }

//    internal class ValidationStatusConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(ValidationStatus) || t == typeof(ValidationStatus?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "OK":
//                    return ValidationStatus.Ok;
//                case "OK.MULTIPLE_RESULTS":
//                    return ValidationStatus.OkMultipleResults;
//                case "OK.PARTIAL":
//                    return ValidationStatus.OkPartial;
//            }
//            throw new Exception("Cannot unmarshal type ValidationStatus");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (ValidationStatus)untypedValue;
//            switch (value)
//            {
//                case ValidationStatus.Ok:
//                    serializer.Serialize(writer, "OK");
//                    return;
//                case ValidationStatus.OkMultipleResults:
//                    serializer.Serialize(writer, "OK.MULTIPLE_RESULTS");
//                    return;
//                case ValidationStatus.OkPartial:
//                    serializer.Serialize(writer, "OK.PARTIAL");
//                    return;
//            }
//            throw new Exception("Cannot marshal type ValidationStatus");
//        }

//        public static readonly ValidationStatusConverter Singleton = new ValidationStatusConverter();
//    }

//    internal class CountryOfResidenceConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(CountryOfResidence) || t == typeof(CountryOfResidence?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "fra":
//                    return CountryOfResidence.Fra;
//                case "irl":
//                    return CountryOfResidence.Irl;
//            }
//            throw new Exception("Cannot unmarshal type CountryOfResidence");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (CountryOfResidence)untypedValue;
//            switch (value)
//            {
//                case CountryOfResidence.Fra:
//                    serializer.Serialize(writer, "fra");
//                    return;
//                case CountryOfResidence.Irl:
//                    serializer.Serialize(writer, "irl");
//                    return;
//            }
//            throw new Exception("Cannot marshal type CountryOfResidence");
//        }

//        public static readonly CountryOfResidenceConverter Singleton = new CountryOfResidenceConverter();
//    }

//    internal class DistanceConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(Distance) || t == typeof(Distance?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "n/a")
//            {
//                return Distance.NA;
//            }
//            throw new Exception("Cannot unmarshal type Distance");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (Distance)untypedValue;
//            if (value == Distance.NA)
//            {
//                serializer.Serialize(writer, "n/a");
//                return;
//            }
//            throw new Exception("Cannot marshal type Distance");
//        }

//        public static readonly DistanceConverter Singleton = new DistanceConverter();
//    }

//    internal class EmploymentCategoryDescriptionConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(EmploymentCategoryDescription) || t == typeof(EmploymentCategoryDescription?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "Preferred contractor":
//                    return EmploymentCategoryDescription.PreferredContractor;
//                case "Vendor":
//                    return EmploymentCategoryDescription.Vendor;
//            }
//            throw new Exception("Cannot unmarshal type EmploymentCategoryDescription");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (EmploymentCategoryDescription)untypedValue;
//            switch (value)
//            {
//                case EmploymentCategoryDescription.PreferredContractor:
//                    serializer.Serialize(writer, "Preferred contractor");
//                    return;
//                case EmploymentCategoryDescription.Vendor:
//                    serializer.Serialize(writer, "Vendor");
//                    return;
//            }
//            throw new Exception("Cannot marshal type EmploymentCategoryDescription");
//        }

//        public static readonly EmploymentCategoryDescriptionConverter Singleton = new EmploymentCategoryDescriptionConverter();
//    }

//    internal class EmploymentEligibilityStatusConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(EmploymentEligibilityStatus) || t == typeof(EmploymentEligibilityStatus?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "pass")
//            {
//                return EmploymentEligibilityStatus.Pass;
//            }
//            throw new Exception("Cannot unmarshal type EmploymentEligibilityStatus");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (EmploymentEligibilityStatus)untypedValue;
//            if (value == EmploymentEligibilityStatus.Pass)
//            {
//                serializer.Serialize(writer, "pass");
//                return;
//            }
//            throw new Exception("Cannot marshal type EmploymentEligibilityStatus");
//        }

//        public static readonly EmploymentEligibilityStatusConverter Singleton = new EmploymentEligibilityStatusConverter();
//    }

//    internal class ImagePathConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(ImagePath) || t == typeof(ImagePath?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "https://tie.interpreterintelligence.com/images/placeholder.png")
//            {
//                return ImagePath.HttpsTieInterpreterintelligenceComImagesPlaceholderPng;
//            }
//            throw new Exception("Cannot unmarshal type ImagePath");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (ImagePath)untypedValue;
//            if (value == ImagePath.HttpsTieInterpreterintelligenceComImagesPlaceholderPng)
//            {
//                serializer.Serialize(writer, "https://tie.interpreterintelligence.com/images/placeholder.png");
//                return;
//            }
//            throw new Exception("Cannot marshal type ImagePath");
//        }

//        public static readonly ImagePathConverter Singleton = new ImagePathConverter();
//    }

//    internal class TypeEnumConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "language")
//            {
//                return TypeEnum.Language;
//            }
//            throw new Exception("Cannot unmarshal type TypeEnum");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (TypeEnum)untypedValue;
//            if (value == TypeEnum.Language)
//            {
//                serializer.Serialize(writer, "language");
//                return;
//            }
//            throw new Exception("Cannot marshal type TypeEnum");
//        }

//        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
//    }

//    internal class MoreLanguagesConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(MoreLanguages) || t == typeof(MoreLanguages?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "":
//                    return MoreLanguages.Empty;
//                case " (+1)":
//                    return MoreLanguages.The1;
//                case " (+3)":
//                    return MoreLanguages.The3;
//                case " (+4)":
//                    return MoreLanguages.The4;
//            }
//            throw new Exception("Cannot unmarshal type MoreLanguages");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (MoreLanguages)untypedValue;
//            switch (value)
//            {
//                case MoreLanguages.Empty:
//                    serializer.Serialize(writer, "");
//                    return;
//                case MoreLanguages.The1:
//                    serializer.Serialize(writer, " (+1)");
//                    return;
//                case MoreLanguages.The3:
//                    serializer.Serialize(writer, " (+3)");
//                    return;
//                case MoreLanguages.The4:
//                    serializer.Serialize(writer, " (+4)");
//                    return;
//            }
//            throw new Exception("Cannot marshal type MoreLanguages");
//        }

//        public static readonly MoreLanguagesConverter Singleton = new MoreLanguagesConverter();
//    }

//    internal class PaymentMethodIdConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(PaymentMethodId) || t == typeof(PaymentMethodId?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            switch (reader.TokenType)
//            {
//                case JsonToken.Integer:
//                    var integerValue = serializer.Deserialize<long>(reader);
//                    return new PaymentMethodId { Integer = integerValue };
//                case JsonToken.String:
//                case JsonToken.Date:
//                    var stringValue = serializer.Deserialize<BusinessUnitId>(reader);
//                    return new PaymentMethodId { Enum = stringValue };
//            }
//            throw new Exception("Cannot unmarshal type PaymentMethodId");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            var value = (PaymentMethodId)untypedValue;
//            if (value.Integer != null)
//            {
//                serializer.Serialize(writer, value.Integer.Value);
//                return;
//            }
//            if (value.Enum != null)
//            {
//                serializer.Serialize(writer, value.Enum);
//                return;
//            }
//            throw new Exception("Cannot marshal type PaymentMethodId");
//        }

//        public static readonly PaymentMethodIdConverter Singleton = new PaymentMethodIdConverter();
//    }

//    internal class PaymentMethodNameConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(PaymentMethodName) || t == typeof(PaymentMethodName?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "":
//                    return PaymentMethodName.Empty;
//                case "EFT":
//                    return PaymentMethodName.Eft;
//                case "Overseas":
//                    return PaymentMethodName.Overseas;
//            }
//            throw new Exception("Cannot unmarshal type PaymentMethodName");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (PaymentMethodName)untypedValue;
//            switch (value)
//            {
//                case PaymentMethodName.Empty:
//                    serializer.Serialize(writer, "");
//                    return;
//                case PaymentMethodName.Eft:
//                    serializer.Serialize(writer, "EFT");
//                    return;
//                case PaymentMethodName.Overseas:
//                    serializer.Serialize(writer, "Overseas");
//                    return;
//            }
//            throw new Exception("Cannot marshal type PaymentMethodName");
//        }

//        public static readonly PaymentMethodNameConverter Singleton = new PaymentMethodNameConverter();
//    }

//    internal class InpersonConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(Inperson) || t == typeof(Inperson?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "summary unavailable")
//            {
//                return Inperson.SummaryUnavailable;
//            }
//            throw new Exception("Cannot unmarshal type Inperson");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (Inperson)untypedValue;
//            if (value == Inperson.SummaryUnavailable)
//            {
//                serializer.Serialize(writer, "summary unavailable");
//                return;
//            }
//            throw new Exception("Cannot marshal type Inperson");
//        }

//        public static readonly InpersonConverter Singleton = new InpersonConverter();
//    }

//    internal class ClassConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(Class) || t == typeof(Class?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "com.ngs.id.model.type.ActiveContactStatus":
//                    return Class.ComNgsIdModelTypeActiveContactStatus;
//                case "com.ngs.id.model.type.InactiveStatus":
//                    return Class.ComNgsIdModelTypeInactiveStatus;
//            }
//            throw new Exception("Cannot unmarshal type Class");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (Class)untypedValue;
//            switch (value)
//            {
//                case Class.ComNgsIdModelTypeActiveContactStatus:
//                    serializer.Serialize(writer, "com.ngs.id.model.type.ActiveContactStatus");
//                    return;
//                case Class.ComNgsIdModelTypeInactiveStatus:
//                    serializer.Serialize(writer, "com.ngs.id.model.type.InactiveStatus");
//                    return;
//            }
//            throw new Exception("Cannot marshal type Class");
//        }

//        public static readonly ClassConverter Singleton = new ClassConverter();
//    }

//    internal class DescriptionConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "Active":
//                    return Description.Active;
//                case "Inactive":
//                    return Description.Inactive;
//            }
//            throw new Exception("Cannot unmarshal type Description");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (Description)untypedValue;
//            switch (value)
//            {
//                case Description.Active:
//                    serializer.Serialize(writer, "Active");
//                    return;
//                case Description.Inactive:
//                    serializer.Serialize(writer, "Inactive");
//                    return;
//            }
//            throw new Exception("Cannot marshal type Description");
//        }

//        public static readonly DescriptionConverter Singleton = new DescriptionConverter();
//    }

//    internal class NameKeyConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(NameKey) || t == typeof(NameKey?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "active":
//                    return NameKey.Active;
//                case "inactive":
//                    return NameKey.Inactive;
//            }
//            throw new Exception("Cannot unmarshal type NameKey");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (NameKey)untypedValue;
//            switch (value)
//            {
//                case NameKey.Active:
//                    serializer.Serialize(writer, "active");
//                    return;
//                case NameKey.Inactive:
//                    serializer.Serialize(writer, "inactive");
//                    return;
//            }
//            throw new Exception("Cannot marshal type NameKey");
//        }

//        public static readonly NameKeyConverter Singleton = new NameKeyConverter();
//    }
//}
using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainProject
{



}
