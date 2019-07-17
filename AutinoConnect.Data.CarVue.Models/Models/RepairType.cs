using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class RepairType
    {
        public RepairType()
        {
            EnquiryPartnerPackage = new HashSet<EnquiryPartnerPackage>();
            GarageRepairType = new HashSet<GarageRepairType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Guid Ref { get; set; }

        public virtual ICollection<EnquiryPartnerPackage> EnquiryPartnerPackage { get; set; }
        public virtual ICollection<GarageRepairType> GarageRepairType { get; set; }
    }
}
