using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class TaxRate
    {
        public TaxRate()
        {
            TaxRateHistory = new HashSet<TaxRateHistory>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<TaxRateHistory> TaxRateHistory { get; set; }
    }
}
