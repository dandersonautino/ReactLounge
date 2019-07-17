using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageUser
    {
        public GarageUser()
        {
            AccountCreatedByNavigation = new HashSet<Account>();
            AccountDeletedByNavigation = new HashSet<Account>();
            AccountUpdatedByNavigation = new HashSet<Account>();
            BillingAccountInvoiceeCreatedByNavigation = new HashSet<BillingAccountInvoicee>();
            BillingAccountInvoiceeDeletedByNavigation = new HashSet<BillingAccountInvoicee>();
            BillingAccountInvoiceeUpdatedByNavigation = new HashSet<BillingAccountInvoicee>();
            CommunicationMethod = new HashSet<CommunicationMethod>();
            ContactCreatedByNavigation = new HashSet<Contact>();
            ContactDeletedByNavigation = new HashSet<Contact>();
            ContactUpdatedByNavigation = new HashSet<Contact>();
            DropOffTimeCreatedByNavigation = new HashSet<DropOffTime>();
            DropOffTimeDeletedByNavigation = new HashSet<DropOffTime>();
            DropOffTimeUpdatedByNavigation = new HashSet<DropOffTime>();
            EnquiryAcceptedByNavigation = new HashSet<Enquiry>();
            EnquiryDeclinedByNavigation = new HashSet<Enquiry>();
            EnquiryMessage = new HashSet<EnquiryMessage>();
            EnquiryPartnerGarageUser = new HashSet<EnquiryPartnerGarageUser>();
            EnquiryPartnerPackage = new HashSet<EnquiryPartnerPackage>();
            EnquiryPartnerThemeCreatedByNavigation = new HashSet<EnquiryPartnerTheme>();
            EnquiryPartnerThemeDeletedByNavigation = new HashSet<EnquiryPartnerTheme>();
            EnquiryPartnerThemeUpdatedByNavigation = new HashSet<EnquiryPartnerTheme>();
            GarageDeletedByNavigation = new HashSet<Garage>();
            GarageEnquiryPartnerCreatedByNavigation = new HashSet<GarageEnquiryPartner>();
            GarageEnquiryPartnerModifiedByNavigation = new HashSet<GarageEnquiryPartner>();
            GarageItemType = new HashSet<GarageItemType>();
            GarageOpeningTime = new HashSet<GarageOpeningTime>();
            GarageRepairType = new HashSet<GarageRepairType>();
            GarageThemeCreatedByNavigation = new HashSet<GarageTheme>();
            GarageThemeDeletedByNavigation = new HashSet<GarageTheme>();
            GarageThemeUpdatedByNavigation = new HashSet<GarageTheme>();
            GarageUpdatedByNavigation = new HashSet<Garage>();
            GarageUserMetaData = new HashSet<GarageUserMetaData>();
            GarageUserPosition = new HashSet<GarageUserPosition>();
            InternalNote = new HashSet<InternalNote>();
            ItemCreatedByNavigation = new HashSet<Item>();
            ItemUpdatedByNavigation = new HashSet<Item>();
            JobAssignee = new HashSet<JobAssignee>();
            JobChatCreatedByNavigation = new HashSet<JobChat>();
            JobChatDeletedByNavigation = new HashSet<JobChat>();
            JobCreatedByNavigation = new HashSet<Job>();
            JobDeclinedByNavigation = new HashSet<Job>();
            JobDeletedByNavigation = new HashSet<Job>();
            JobMessage = new HashSet<JobMessage>();
            JobUpdatedByNavigation = new HashSet<Job>();
            MapCreatedByNavigation = new HashSet<Map>();
            MapDeletedByNavigation = new HashSet<Map>();
            PackageCreatedByNavigation = new HashSet<Package>();
            PackageDeletedByNavigation = new HashSet<Package>();
            PackageProductCreatedByNavigation = new HashSet<PackageProduct>();
            PackageProductDeletedByNavigation = new HashSet<PackageProduct>();
            PackageProductUpdatedByNavigation = new HashSet<PackageProduct>();
            PackageUpdatedByNavigation = new HashSet<Package>();
            ProductCreatedByNavigation = new HashSet<Product>();
            ProductDeletedByNavigation = new HashSet<Product>();
            ProductUpdatedByNavigation = new HashSet<Product>();
            RepairCreatedByNavigation = new HashSet<Repair>();
            RepairDeletedByNavigation = new HashSet<Repair>();
            RepairMessage = new HashSet<RepairMessage>();
            RepairUpdatedByNavigation = new HashSet<Repair>();
            ResourceAvailabilityCreatedByNavigation = new HashSet<ResourceAvailability>();
            ResourceAvailabilityDeletedByNavigation = new HashSet<ResourceAvailability>();
            ResourceAvailabilityUpdatedByNavigation = new HashSet<ResourceAvailability>();
            ResourceCreatedByNavigation = new HashSet<Resource>();
            ResourceDeletedByNavigation = new HashSet<Resource>();
            ResourceUpdatedByNavigation = new HashSet<Resource>();
            Summary = new HashSet<Summary>();
            ThemeCreatedByNavigation = new HashSet<Theme>();
            ThemeDeletedByNavigation = new HashSet<Theme>();
            ThemeGroupCreatedByNavigation = new HashSet<ThemeGroup>();
            ThemeGroupDeletedByNavigation = new HashSet<ThemeGroup>();
            ThemeGroupUpdatedByNavigation = new HashSet<ThemeGroup>();
            ThemeUpdatedByNavigation = new HashSet<Theme>();
            VehicleCreatedByNavigation = new HashSet<Vehicle>();
            VehicleDeletedByNavigation = new HashSet<Vehicle>();
            VehicleUpdatedByNavigation = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public int IdentityAccountId { get; set; }
        public int PermissionId { get; set; }
        public int CPositions { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? InvitedDate { get; set; }
        public Guid ReplicationId { get; set; }
        public int? MapReferenceContainerId { get; set; }
        public string CdkuserName { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual ICollection<Account> AccountCreatedByNavigation { get; set; }
        public virtual ICollection<Account> AccountDeletedByNavigation { get; set; }
        public virtual ICollection<Account> AccountUpdatedByNavigation { get; set; }
        public virtual ICollection<BillingAccountInvoicee> BillingAccountInvoiceeCreatedByNavigation { get; set; }
        public virtual ICollection<BillingAccountInvoicee> BillingAccountInvoiceeDeletedByNavigation { get; set; }
        public virtual ICollection<BillingAccountInvoicee> BillingAccountInvoiceeUpdatedByNavigation { get; set; }
        public virtual ICollection<CommunicationMethod> CommunicationMethod { get; set; }
        public virtual ICollection<Contact> ContactCreatedByNavigation { get; set; }
        public virtual ICollection<Contact> ContactDeletedByNavigation { get; set; }
        public virtual ICollection<Contact> ContactUpdatedByNavigation { get; set; }
        public virtual ICollection<DropOffTime> DropOffTimeCreatedByNavigation { get; set; }
        public virtual ICollection<DropOffTime> DropOffTimeDeletedByNavigation { get; set; }
        public virtual ICollection<DropOffTime> DropOffTimeUpdatedByNavigation { get; set; }
        public virtual ICollection<Enquiry> EnquiryAcceptedByNavigation { get; set; }
        public virtual ICollection<Enquiry> EnquiryDeclinedByNavigation { get; set; }
        public virtual ICollection<EnquiryMessage> EnquiryMessage { get; set; }
        public virtual ICollection<EnquiryPartnerGarageUser> EnquiryPartnerGarageUser { get; set; }
        public virtual ICollection<EnquiryPartnerPackage> EnquiryPartnerPackage { get; set; }
        public virtual ICollection<EnquiryPartnerTheme> EnquiryPartnerThemeCreatedByNavigation { get; set; }
        public virtual ICollection<EnquiryPartnerTheme> EnquiryPartnerThemeDeletedByNavigation { get; set; }
        public virtual ICollection<EnquiryPartnerTheme> EnquiryPartnerThemeUpdatedByNavigation { get; set; }
        public virtual ICollection<Garage> GarageDeletedByNavigation { get; set; }
        public virtual ICollection<GarageEnquiryPartner> GarageEnquiryPartnerCreatedByNavigation { get; set; }
        public virtual ICollection<GarageEnquiryPartner> GarageEnquiryPartnerModifiedByNavigation { get; set; }
        public virtual ICollection<GarageItemType> GarageItemType { get; set; }
        public virtual ICollection<GarageOpeningTime> GarageOpeningTime { get; set; }
        public virtual ICollection<GarageRepairType> GarageRepairType { get; set; }
        public virtual ICollection<GarageTheme> GarageThemeCreatedByNavigation { get; set; }
        public virtual ICollection<GarageTheme> GarageThemeDeletedByNavigation { get; set; }
        public virtual ICollection<GarageTheme> GarageThemeUpdatedByNavigation { get; set; }
        public virtual ICollection<Garage> GarageUpdatedByNavigation { get; set; }
        public virtual ICollection<GarageUserMetaData> GarageUserMetaData { get; set; }
        public virtual ICollection<GarageUserPosition> GarageUserPosition { get; set; }
        public virtual ICollection<InternalNote> InternalNote { get; set; }
        public virtual ICollection<Item> ItemCreatedByNavigation { get; set; }
        public virtual ICollection<Item> ItemUpdatedByNavigation { get; set; }
        public virtual ICollection<JobAssignee> JobAssignee { get; set; }
        public virtual ICollection<JobChat> JobChatCreatedByNavigation { get; set; }
        public virtual ICollection<JobChat> JobChatDeletedByNavigation { get; set; }
        public virtual ICollection<Job> JobCreatedByNavigation { get; set; }
        public virtual ICollection<Job> JobDeclinedByNavigation { get; set; }
        public virtual ICollection<Job> JobDeletedByNavigation { get; set; }
        public virtual ICollection<JobMessage> JobMessage { get; set; }
        public virtual ICollection<Job> JobUpdatedByNavigation { get; set; }
        public virtual ICollection<Map> MapCreatedByNavigation { get; set; }
        public virtual ICollection<Map> MapDeletedByNavigation { get; set; }
        public virtual ICollection<Package> PackageCreatedByNavigation { get; set; }
        public virtual ICollection<Package> PackageDeletedByNavigation { get; set; }
        public virtual ICollection<PackageProduct> PackageProductCreatedByNavigation { get; set; }
        public virtual ICollection<PackageProduct> PackageProductDeletedByNavigation { get; set; }
        public virtual ICollection<PackageProduct> PackageProductUpdatedByNavigation { get; set; }
        public virtual ICollection<Package> PackageUpdatedByNavigation { get; set; }
        public virtual ICollection<Product> ProductCreatedByNavigation { get; set; }
        public virtual ICollection<Product> ProductDeletedByNavigation { get; set; }
        public virtual ICollection<Product> ProductUpdatedByNavigation { get; set; }
        public virtual ICollection<Repair> RepairCreatedByNavigation { get; set; }
        public virtual ICollection<Repair> RepairDeletedByNavigation { get; set; }
        public virtual ICollection<RepairMessage> RepairMessage { get; set; }
        public virtual ICollection<Repair> RepairUpdatedByNavigation { get; set; }
        public virtual ICollection<ResourceAvailability> ResourceAvailabilityCreatedByNavigation { get; set; }
        public virtual ICollection<ResourceAvailability> ResourceAvailabilityDeletedByNavigation { get; set; }
        public virtual ICollection<ResourceAvailability> ResourceAvailabilityUpdatedByNavigation { get; set; }
        public virtual ICollection<Resource> ResourceCreatedByNavigation { get; set; }
        public virtual ICollection<Resource> ResourceDeletedByNavigation { get; set; }
        public virtual ICollection<Resource> ResourceUpdatedByNavigation { get; set; }
        public virtual ICollection<Summary> Summary { get; set; }
        public virtual ICollection<Theme> ThemeCreatedByNavigation { get; set; }
        public virtual ICollection<Theme> ThemeDeletedByNavigation { get; set; }
        public virtual ICollection<ThemeGroup> ThemeGroupCreatedByNavigation { get; set; }
        public virtual ICollection<ThemeGroup> ThemeGroupDeletedByNavigation { get; set; }
        public virtual ICollection<ThemeGroup> ThemeGroupUpdatedByNavigation { get; set; }
        public virtual ICollection<Theme> ThemeUpdatedByNavigation { get; set; }
        public virtual ICollection<Vehicle> VehicleCreatedByNavigation { get; set; }
        public virtual ICollection<Vehicle> VehicleDeletedByNavigation { get; set; }
        public virtual ICollection<Vehicle> VehicleUpdatedByNavigation { get; set; }
    }
}
