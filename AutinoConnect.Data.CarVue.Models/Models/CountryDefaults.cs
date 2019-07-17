using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class CountryDefaults
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int TimeZoneId { get; set; }
        public int CultureId { get; set; }
        public string CurrencyCode { get; set; }

        public virtual Country Country { get; set; }
        public virtual CurrencyCode CurrencyCodeNavigation { get; set; }
        public virtual TimeZone TimeZone { get; set; }
    }
}
