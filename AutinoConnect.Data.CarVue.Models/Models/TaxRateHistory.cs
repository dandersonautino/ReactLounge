using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class TaxRateHistory
    {
        public int Id { get; set; }
        public int TaxRateId { get; set; }
        public decimal Rate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual TaxRate TaxRate { get; set; }
    }
}
