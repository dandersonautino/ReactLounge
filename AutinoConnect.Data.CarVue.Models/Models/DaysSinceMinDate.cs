using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class DaysSinceMinDate
    {
        public int Id { get; set; }
        public DateTime ActualDate { get; set; }
        public int DayNum { get; set; }
        public string DayName { get; set; }
    }
}
