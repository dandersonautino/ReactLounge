using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class TimeZone
    {
        public TimeZone()
        {
            CountryDefaults = new HashSet<CountryDefaults>();
            Garage = new HashSet<Garage>();
        }

        public int Id { get; set; }
        public string TimeZoneId { get; set; }
        public bool Supported { get; set; }

        public virtual ICollection<CountryDefaults> CountryDefaults { get; set; }
        public virtual ICollection<Garage> Garage { get; set; }
    }
}
