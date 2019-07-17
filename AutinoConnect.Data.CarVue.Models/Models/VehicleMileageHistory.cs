using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class VehicleMileageHistory
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int OdometerMeasureTypeId { get; set; }
        public int OdometerReading { get; set; }
        public DateTime RecordedDate { get; set; }

        public virtual OdometerMeasureType OdometerMeasureType { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
