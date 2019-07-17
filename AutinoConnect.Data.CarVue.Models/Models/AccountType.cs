using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            Account = new HashSet<Account>();
        }

        public int Id { get; set; }
        public int AccountClassId { get; set; }
        public string Name { get; set; }

        public virtual AccountClass AccountClass { get; set; }
        public virtual ICollection<Account> Account { get; set; }
    }
}
