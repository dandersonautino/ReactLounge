using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class PlanTemplateFeature
    {
        public int Id { get; set; }
        public int PlanTemplateId { get; set; }
        public int FeatureId { get; set; }
        public bool IsCustomizableByGarage { get; set; }
        public bool IsActive { get; set; }
        public Guid ReplicationId { get; set; }
        public int OrderBy { get; set; }

        public virtual Feature Feature { get; set; }
        public virtual PlanTemplate PlanTemplate { get; set; }
    }
}
