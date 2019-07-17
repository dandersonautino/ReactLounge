using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class AccountClass
    {
        public AccountClass()
        {
            AccountType = new HashSet<AccountType>();
            Default = new HashSet<Default>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AccountType> AccountType { get; set; }
        public virtual ICollection<Default> Default { get; set; }
    }
}
