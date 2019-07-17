using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryPartner
    {
        public EnquiryPartner()
        {
            ApiPartnerIntegrationModifiers = new HashSet<ApiPartnerIntegrationModifiers>();
            Enquiry = new HashSet<Enquiry>();
            EnquiryPartnerGarageVehicle = new HashSet<EnquiryPartnerGarageVehicle>();
            EnquiryPartnerMetaData = new HashSet<EnquiryPartnerMetaData>();
            EnquiryPartnerPackage = new HashSet<EnquiryPartnerPackage>();
            EnquiryPartnerTheme = new HashSet<EnquiryPartnerTheme>();
            GarageEnquiryPartner = new HashSet<GarageEnquiryPartner>();
            Summary = new HashSet<Summary>();
            VehicleClassification = new HashSet<VehicleClassification>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApiPartnerIntegrationModifiers> ApiPartnerIntegrationModifiers { get; set; }
        public virtual ICollection<Enquiry> Enquiry { get; set; }
        public virtual ICollection<EnquiryPartnerGarageVehicle> EnquiryPartnerGarageVehicle { get; set; }
        public virtual ICollection<EnquiryPartnerMetaData> EnquiryPartnerMetaData { get; set; }
        public virtual ICollection<EnquiryPartnerPackage> EnquiryPartnerPackage { get; set; }
        public virtual ICollection<EnquiryPartnerTheme> EnquiryPartnerTheme { get; set; }
        public virtual ICollection<GarageEnquiryPartner> GarageEnquiryPartner { get; set; }
        public virtual ICollection<Summary> Summary { get; set; }
        public virtual ICollection<VehicleClassification> VehicleClassification { get; set; }
    }
}
