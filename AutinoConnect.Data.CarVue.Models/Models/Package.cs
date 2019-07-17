using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Package
    {
        public Package()
        {
            AddonPackage = new HashSet<AddonPackage>();
            EnquiryPackageInfo = new HashSet<EnquiryPackageInfo>();
            GarageEnquiryPartnerPackage = new HashSet<GarageEnquiryPartnerPackage>();
            PackageProduct = new HashSet<PackageProduct>();
            Repair = new HashSet<Repair>();
            RepairMessage = new HashSet<RepairMessage>();
            ResourceAvailabilityPackage = new HashSet<ResourceAvailabilityPackage>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public int GarageRepairTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal BookedTime { get; set; }
        public string RequestedNote { get; set; }
        public string RequiredNote { get; set; }
        public string TechnicianNote { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool ShowOnline { get; set; }
        public bool ShowOnlinePrice { get; set; }
        public decimal OnlineValue { get; set; }
        public string CurrencyCode { get; set; }
        public string OnlineDescription { get; set; }
        public string OnlinePriceText { get; set; }
        public bool AllPackages { get; set; }
        public int OnlineOrder { get; set; }
        public bool AdminFavourite { get; set; }
        public int? AdminOrder { get; set; }
        public decimal? InternalValue { get; set; }
        public bool? IsActive { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual CurrencyCode CurrencyCodeNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual GarageRepairType GarageRepairType { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual ICollection<AddonPackage> AddonPackage { get; set; }
        public virtual ICollection<EnquiryPackageInfo> EnquiryPackageInfo { get; set; }
        public virtual ICollection<GarageEnquiryPartnerPackage> GarageEnquiryPartnerPackage { get; set; }
        public virtual ICollection<PackageProduct> PackageProduct { get; set; }
        public virtual ICollection<Repair> Repair { get; set; }
        public virtual ICollection<RepairMessage> RepairMessage { get; set; }
        public virtual ICollection<ResourceAvailabilityPackage> ResourceAvailabilityPackage { get; set; }
    }
}
