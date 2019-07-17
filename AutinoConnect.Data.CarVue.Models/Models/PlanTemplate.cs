using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class PlanTemplate
    {
        public PlanTemplate()
        {
            GaragePlan = new HashSet<GaragePlan>();
            PlanTemplateFeature = new HashSet<PlanTemplateFeature>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public int? PartnerId { get; set; }
        public bool IsActive { get; set; }
        public Guid ReplicationId { get; set; }
        public int TierId { get; set; }

        public virtual Country Country { get; set; }
        public virtual Partner Partner { get; set; }
        public virtual Tier Tier { get; set; }
        public virtual ICollection<GaragePlan> GaragePlan { get; set; }
        public virtual ICollection<PlanTemplateFeature> PlanTemplateFeature { get; set; }
    }
}
