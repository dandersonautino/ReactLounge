using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class TaxGroupRate
    {
        public int TaxGroupId { get; set; }
        public int TaxRateId { get; set; }
        public int TaxRateTypeId { get; set; }
        public int Order { get; set; }
    }
}
