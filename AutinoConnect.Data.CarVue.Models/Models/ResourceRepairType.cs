using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ResourceRepairType
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int GarageRepairTypeId { get; set; }

        public virtual GarageRepairType GarageRepairType { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
