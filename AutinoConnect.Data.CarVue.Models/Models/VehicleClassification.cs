using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class VehicleClassification
    {
        public VehicleClassification()
        {
            EnquiryPackageInfo = new HashSet<EnquiryPackageInfo>();
            EnquiryPartnerMenuPrice = new HashSet<EnquiryPartnerMenuPrice>();
            GarageEnquiryPartnerMenuPrice = new HashSet<GarageEnquiryPartnerMenuPrice>();
            VehicleClassificationRelation = new HashSet<VehicleClassificationRelation>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public int EnquiryPartnerId { get; set; }
        public bool IsDeleted { get; set; }
        public string CountryCode { get; set; }

        public virtual EnquiryPartner EnquiryPartner { get; set; }
        public virtual ICollection<EnquiryPackageInfo> EnquiryPackageInfo { get; set; }
        public virtual ICollection<EnquiryPartnerMenuPrice> EnquiryPartnerMenuPrice { get; set; }
        public virtual ICollection<GarageEnquiryPartnerMenuPrice> GarageEnquiryPartnerMenuPrice { get; set; }
        public virtual ICollection<VehicleClassificationRelation> VehicleClassificationRelation { get; set; }
    }
}
