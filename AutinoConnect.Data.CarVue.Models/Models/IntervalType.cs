using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class IntervalType
    {
        public IntervalType()
        {
            GarageCampaign = new HashSet<GarageCampaign>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GarageCampaign> GarageCampaign { get; set; }
    }
}
