using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class TaxRateType
    {
        public TaxRateType()
        {
            CountryTaxRateTemplate = new HashSet<CountryTaxRateTemplate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CountryTaxRateTemplate> CountryTaxRateTemplate { get; set; }
    }
}
