using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Garage
    {
        public Garage()
        {
            Account = new HashSet<Account>();
            DropOffTime = new HashSet<DropOffTime>();
            Enquiry = new HashSet<Enquiry>();
            EnquiryPartnerGarageUser = new HashSet<EnquiryPartnerGarageUser>();
            EnquiryPartnerGarageVehicle = new HashSet<EnquiryPartnerGarageVehicle>();
            GarageAvailability = new HashSet<GarageAvailability>();
            GarageCampaign = new HashSet<GarageCampaign>();
            GarageCampaignEvent = new HashSet<GarageCampaignEvent>();
            GarageCommunicationMethod = new HashSet<GarageCommunicationMethod>();
            GarageContact = new HashSet<GarageContact>();
            GarageDefaultAccount = new HashSet<GarageDefaultAccount>();
            GarageDefaultTaxGroup = new HashSet<GarageDefaultTaxGroup>();
            GarageEnquiryPartner = new HashSet<GarageEnquiryPartner>();
            GarageEnquiryPartnerPackage = new HashSet<GarageEnquiryPartnerPackage>();
            GarageHoliday = new HashSet<GarageHoliday>();
            GarageIncrement = new HashSet<GarageIncrement>();
            GarageItemType = new HashSet<GarageItemType>();
            GarageJobStatusLevel = new HashSet<GarageJobStatusLevel>();
            GarageManufacturer = new HashSet<GarageManufacturer>();
            GarageMetaData = new HashSet<GarageMetaData>();
            GarageMetadataType = new HashSet<GarageMetadataType>();
            GarageOpeningTime = new HashSet<GarageOpeningTime>();
            GaragePlan = new HashSet<GaragePlan>();
            GarageReminderType = new HashSet<GarageReminderType>();
            GarageRepairType = new HashSet<GarageRepairType>();
            GarageTheme = new HashSet<GarageTheme>();
            GarageUser = new HashSet<GarageUser>();
            GarageVehicle = new HashSet<GarageVehicle>();
            ImportFile = new HashSet<ImportFile>();
            IntegrationUpdateRequest = new HashSet<IntegrationUpdateRequest>();
            Item = new HashSet<Item>();
            Job = new HashSet<Job>();
            LoungeJob = new HashSet<LoungeJob>();
            Map = new HashSet<Map>();
            Package = new HashSet<Package>();
            Product = new HashSet<Product>();
            Resource = new HashSet<Resource>();
            Summary = new HashSet<Summary>();
            TaxGroup = new HashSet<TaxGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int BillingAccountId { get; set; }
        public int? AddressId { get; set; }
        public int CultureId { get; set; }
        public int TimeZoneId { get; set; }
        public int OdometerMeasureTypeId { get; set; }
        public int Modules { get; set; }
        public Guid ReplicationId { get; set; }
        public int RegistrationStatusId { get; set; }
        public int Facilities { get; set; }
        public string OpeningTimes { get; set; }
        public bool AutoAcceptBookings { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string LogoUrl { get; set; }
        public string CurrencyCode { get; set; }
        public int? MapReferenceContainerId { get; set; }
        public bool? SimplifiedJobForm { get; set; }
        public bool IsPilotMode { get; set; }
        public bool DoCdkimport { get; set; }
        public bool IsAddToReport { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public virtual Address Address { get; set; }
        public virtual BillingAccount BillingAccount { get; set; }
        public virtual CurrencyCode CurrencyCodeNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
        public virtual OdometerMeasureType OdometerMeasureType { get; set; }
        public virtual RegistrationStatus RegistrationStatus { get; set; }
        public virtual TimeZone TimeZone { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual GarageOutOfOffice GarageOutOfOffice { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<DropOffTime> DropOffTime { get; set; }
        public virtual ICollection<Enquiry> Enquiry { get; set; }
        public virtual ICollection<EnquiryPartnerGarageUser> EnquiryPartnerGarageUser { get; set; }
        public virtual ICollection<EnquiryPartnerGarageVehicle> EnquiryPartnerGarageVehicle { get; set; }
        public virtual ICollection<GarageAvailability> GarageAvailability { get; set; }
        public virtual ICollection<GarageCampaign> GarageCampaign { get; set; }
        public virtual ICollection<GarageCampaignEvent> GarageCampaignEvent { get; set; }
        public virtual ICollection<GarageCommunicationMethod> GarageCommunicationMethod { get; set; }
        public virtual ICollection<GarageContact> GarageContact { get; set; }
        public virtual ICollection<GarageDefaultAccount> GarageDefaultAccount { get; set; }
        public virtual ICollection<GarageDefaultTaxGroup> GarageDefaultTaxGroup { get; set; }
        public virtual ICollection<GarageEnquiryPartner> GarageEnquiryPartner { get; set; }
        public virtual ICollection<GarageEnquiryPartnerPackage> GarageEnquiryPartnerPackage { get; set; }
        public virtual ICollection<GarageHoliday> GarageHoliday { get; set; }
        public virtual ICollection<GarageIncrement> GarageIncrement { get; set; }
        public virtual ICollection<GarageItemType> GarageItemType { get; set; }
        public virtual ICollection<GarageJobStatusLevel> GarageJobStatusLevel { get; set; }
        public virtual ICollection<GarageManufacturer> GarageManufacturer { get; set; }
        public virtual ICollection<GarageMetaData> GarageMetaData { get; set; }
        public virtual ICollection<GarageMetadataType> GarageMetadataType { get; set; }
        public virtual ICollection<GarageOpeningTime> GarageOpeningTime { get; set; }
        public virtual ICollection<GaragePlan> GaragePlan { get; set; }
        public virtual ICollection<GarageReminderType> GarageReminderType { get; set; }
        public virtual ICollection<GarageRepairType> GarageRepairType { get; set; }
        public virtual ICollection<GarageTheme> GarageTheme { get; set; }
        public virtual ICollection<GarageUser> GarageUser { get; set; }
        public virtual ICollection<GarageVehicle> GarageVehicle { get; set; }
        public virtual ICollection<ImportFile> ImportFile { get; set; }
        public virtual ICollection<IntegrationUpdateRequest> IntegrationUpdateRequest { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<Job> Job { get; set; }
        public virtual ICollection<LoungeJob> LoungeJob { get; set; }
        public virtual ICollection<Map> Map { get; set; }
        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Resource> Resource { get; set; }
        public virtual ICollection<Summary> Summary { get; set; }
        public virtual ICollection<TaxGroup> TaxGroup { get; set; }
    }
}
