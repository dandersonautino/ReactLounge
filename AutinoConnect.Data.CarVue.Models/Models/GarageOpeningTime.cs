using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageOpeningTime
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public int DayOfWeek { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual Garage Garage { get; set; }
    }
}
