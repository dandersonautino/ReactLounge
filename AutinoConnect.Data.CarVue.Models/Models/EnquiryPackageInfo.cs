using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryPackageInfo
    {
        public int Id { get; set; }
        public int EnquiryId { get; set; }
        public int PackageId { get; set; }
        public int? EnquiryPartnerPackageId { get; set; }
        public string Details { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int? ResourceId { get; set; }
        public bool? Booked { get; set; }
        public Guid? VehicleClassificationId { get; set; }

        public virtual Enquiry Enquiry { get; set; }
        public virtual EnquiryPartnerPackage EnquiryPartnerPackage { get; set; }
        public virtual Package Package { get; set; }
        public virtual VehicleClassification VehicleClassification { get; set; }
    }
}
