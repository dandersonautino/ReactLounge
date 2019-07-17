using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class VehicleClassificationRelation
    {
        public Guid VehicleClassificationId { get; set; }
        public int ModelId { get; set; }

        public virtual Model Model { get; set; }
        public virtual VehicleClassification VehicleClassification { get; set; }
    }
}
