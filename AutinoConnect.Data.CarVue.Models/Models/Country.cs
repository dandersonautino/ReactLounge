using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
            CountryTaxRateTemplate = new HashSet<CountryTaxRateTemplate>();
            Feature = new HashSet<Feature>();
            PlanTemplate = new HashSet<PlanTemplate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ReplicationId { get; set; }
        public int AzureRegionId { get; set; }
        public string Code { get; set; }
        public string DialCode { get; set; }
        public bool Supported { get; set; }

        public virtual AzureRegion AzureRegion { get; set; }
        public virtual CountryDefaults CountryDefaults { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<CountryTaxRateTemplate> CountryTaxRateTemplate { get; set; }
        public virtual ICollection<Feature> Feature { get; set; }
        public virtual ICollection<PlanTemplate> PlanTemplate { get; set; }
    }
}
