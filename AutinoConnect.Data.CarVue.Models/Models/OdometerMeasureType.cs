using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class OdometerMeasureType
    {
        public OdometerMeasureType()
        {
            Garage = new HashSet<Garage>();
            Vehicle = new HashSet<Vehicle>();
            VehicleMileageHistory = new HashSet<VehicleMileageHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ReplicationId { get; set; }

        public virtual ICollection<Garage> Garage { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        public virtual ICollection<VehicleMileageHistory> VehicleMileageHistory { get; set; }
    }
}
