using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class OneTimeScriptsExecuted
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? DurationSeconds { get; set; }
        public string ExecutedBy { get; set; }
    }
}
