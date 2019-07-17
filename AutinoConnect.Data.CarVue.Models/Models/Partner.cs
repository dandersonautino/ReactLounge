using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Partner
    {
        public Partner()
        {
            BillingAccount = new HashSet<BillingAccount>();
            PlanTemplate = new HashSet<PlanTemplate>();
        }

        public int Id { get; set; }
        public int PartnerTypeId { get; set; }
        public string Name { get; set; }
        public string ThemeName { get; set; }
        public bool IsActive { get; set; }

        public virtual PartnerType PartnerType { get; set; }
        public virtual ICollection<BillingAccount> BillingAccount { get; set; }
        public virtual ICollection<PlanTemplate> PlanTemplate { get; set; }
    }
}
