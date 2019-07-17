using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class CampaignType
    {
        public CampaignType()
        {
            GarageCampaign = new HashSet<GarageCampaign>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool AbsoluteValue { get; set; }

        public virtual ICollection<GarageCampaign> GarageCampaign { get; set; }
    }
}
