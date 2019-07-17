using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class BillingAccountStatus
    {
        public BillingAccountStatus()
        {
            BillingAccount = new HashSet<BillingAccount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }

        public virtual ICollection<BillingAccount> BillingAccount { get; set; }
    }
}
