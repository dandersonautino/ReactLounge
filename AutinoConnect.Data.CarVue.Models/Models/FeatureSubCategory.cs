using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FeatureSubCategory
    {
        public FeatureSubCategory()
        {
            Feature = new HashSet<Feature>();
        }

        public int Id { get; set; }
        public int FeatureCategoryId { get; set; }
        public string Name { get; set; }

        public virtual FeatureCategory FeatureCategory { get; set; }
        public virtual ICollection<Feature> Feature { get; set; }
    }
}
