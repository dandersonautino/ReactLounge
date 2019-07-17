using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageVehicle
    {
        public int GarageId { get; set; }
        public int VehicleId { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
