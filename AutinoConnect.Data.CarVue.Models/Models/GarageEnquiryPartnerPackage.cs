using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageEnquiryPartnerPackage
    {
        public GarageEnquiryPartnerPackage()
        {
            GarageEnquiryPartnerMenuPrice = new HashSet<GarageEnquiryPartnerMenuPrice>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public int EnquiryPartnerPackageId { get; set; }
        public int PackageId { get; set; }
        public decimal Value { get; set; }
        public string CurrencyCode { get; set; }

        public virtual CurrencyCode CurrencyCodeNavigation { get; set; }
        public virtual EnquiryPartnerPackage EnquiryPartnerPackage { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual Package Package { get; set; }
        public virtual ICollection<GarageEnquiryPartnerMenuPrice> GarageEnquiryPartnerMenuPrice { get; set; }
    }
}
