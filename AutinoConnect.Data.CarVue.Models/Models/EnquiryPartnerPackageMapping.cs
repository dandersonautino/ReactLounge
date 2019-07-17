using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryPartnerPackageMapping
    {
        public Guid PackageRef { get; set; }
        public int EnquiryPartnerId { get; set; }
        public int GarageId { get; set; }
        public int PackageId { get; set; }
    }
}
