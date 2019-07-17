using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageAvailability
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public byte DayOfWeek { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public virtual Garage Garage { get; set; }
    }
}
