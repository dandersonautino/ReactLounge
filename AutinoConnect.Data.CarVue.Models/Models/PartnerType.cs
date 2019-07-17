using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class PartnerType
    {
        public PartnerType()
        {
            Partner = new HashSet<Partner>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Partner> Partner { get; set; }
    }
}
