using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GaragePlan
    {
        public GaragePlan()
        {
            GaragePlanFeature = new HashSet<GaragePlanFeature>();
        }

        public int Id { get; set; }
        public int PlanTemplateId { get; set; }
        public int GarageId { get; set; }
        public bool IsActive { get; set; }
        public Guid ReplicationId { get; set; }
        public bool EmailsOn { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual PlanTemplate PlanTemplate { get; set; }
        public virtual ICollection<GaragePlanFeature> GaragePlanFeature { get; set; }
    }
}
