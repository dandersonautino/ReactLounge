using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Tier
    {
        public Tier()
        {
            FeatureTier = new HashSet<FeatureTier>();
            PlanTemplate = new HashSet<PlanTemplate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public virtual ICollection<FeatureTier> FeatureTier { get; set; }
        public virtual ICollection<PlanTemplate> PlanTemplate { get; set; }
    }
}
