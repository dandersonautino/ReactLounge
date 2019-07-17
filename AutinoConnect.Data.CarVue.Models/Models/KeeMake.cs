using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class KeeMake
    {
        public KeeMake()
        {
            KeeModel = new HashSet<KeeModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<KeeModel> KeeModel { get; set; }
    }
}
