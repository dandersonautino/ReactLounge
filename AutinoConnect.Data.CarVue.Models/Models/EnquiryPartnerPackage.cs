using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryPartnerPackage
    {
        public EnquiryPartnerPackage()
        {
            EnquiryPackageInfo = new HashSet<EnquiryPackageInfo>();
            EnquiryPartnerMenuPrice = new HashSet<EnquiryPartnerMenuPrice>();
            GarageEnquiryPartnerPackage = new HashSet<GarageEnquiryPartnerPackage>();
        }

        public int Id { get; set; }
        public int EnquiryPartnerId { get; set; }
        public string Name { get; set; }
        public Guid Ref { get; set; }
        public string Code { get; set; }
        public int RepairTypeId { get; set; }
        public decimal SalePrice { get; set; }
        public string CurrencyCode { get; set; }
        public string Data { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public string CountryCode { get; set; }
        public decimal Duration { get; set; }
        public string Description { get; set; }

        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual EnquiryPartner EnquiryPartner { get; set; }
        public virtual RepairType RepairType { get; set; }
        public virtual ICollection<EnquiryPackageInfo> EnquiryPackageInfo { get; set; }
        public virtual ICollection<EnquiryPartnerMenuPrice> EnquiryPartnerMenuPrice { get; set; }
        public virtual ICollection<GarageEnquiryPartnerPackage> GarageEnquiryPartnerPackage { get; set; }
    }
}
