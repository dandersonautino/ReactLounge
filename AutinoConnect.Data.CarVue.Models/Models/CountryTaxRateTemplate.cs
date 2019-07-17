using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class CountryTaxRateTemplate
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string TaxGroupCode { get; set; }
        public string TaxRateCode { get; set; }
        public string TaxRateName { get; set; }
        public int TaxRateTypeId { get; set; }
        public decimal TaxRateValue { get; set; }
        public string TaxGroupDescription { get; set; }

        public virtual Country Country { get; set; }
        public virtual TaxRateType TaxRateType { get; set; }
    }
}
