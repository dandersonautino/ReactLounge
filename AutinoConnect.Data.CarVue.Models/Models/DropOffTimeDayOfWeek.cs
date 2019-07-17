using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class DropOffTimeDayOfWeek
    {
        public int Id { get; set; }
        public int DropOffTimeId { get; set; }
        public int DayOfWeek { get; set; }

        public virtual DropOffTime DropOffTime { get; set; }
    }
}
