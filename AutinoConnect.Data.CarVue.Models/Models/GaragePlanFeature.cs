using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GaragePlanFeature
    {
        public int Id { get; set; }
        public int GaragePlanId { get; set; }
        public int FeatureId { get; set; }
        public Guid ReplicationId { get; set; }
        public bool? IsActive { get; set; }
        public int OrderBy { get; set; }

        public virtual Feature Feature { get; set; }
        public virtual GaragePlan GaragePlan { get; set; }
    }
}
