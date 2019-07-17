using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Feature
    {
        public Feature()
        {
            FeatureTier = new HashSet<FeatureTier>();
            GaragePlanFeature = new HashSet<GaragePlanFeature>();
            PlanTemplateFeature = new HashSet<PlanTemplateFeature>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FeatureCategoryId { get; set; }
        public int FeatureSubCategoryId { get; set; }
        public int FeatureTypeId { get; set; }
        public int? CountryId { get; set; }
        public int? ScopeId { get; set; }
        public bool IsActive { get; set; }
        public int Modules { get; set; }
        public bool IsCustomizableByGarage { get; set; }

        public virtual Country Country { get; set; }
        public virtual FeatureCategory FeatureCategory { get; set; }
        public virtual FeatureSubCategory FeatureSubCategory { get; set; }
        public virtual FeatureType FeatureType { get; set; }
        public virtual FeatureScope Scope { get; set; }
        public virtual ICollection<FeatureTier> FeatureTier { get; set; }
        public virtual ICollection<GaragePlanFeature> GaragePlanFeature { get; set; }
        public virtual ICollection<PlanTemplateFeature> PlanTemplateFeature { get; set; }
    }
}
