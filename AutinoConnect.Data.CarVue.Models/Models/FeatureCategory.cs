using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FeatureCategory
    {
        public FeatureCategory()
        {
            Feature = new HashSet<Feature>();
            FeatureSubCategory = new HashSet<FeatureSubCategory>();
        }

        public int Id { get; set; }
        public string CategoryValue { get; set; }

        public virtual ICollection<Feature> Feature { get; set; }
        public virtual ICollection<FeatureSubCategory> FeatureSubCategory { get; set; }
    }
}
