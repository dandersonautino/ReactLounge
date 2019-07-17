using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FeatureScope
    {
        public FeatureScope()
        {
            Feature = new HashSet<Feature>();
        }

        public int Id { get; set; }
        public string ScopeValue { get; set; }

        public virtual ICollection<Feature> Feature { get; set; }
    }
}
