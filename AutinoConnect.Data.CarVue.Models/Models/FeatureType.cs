using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FeatureType
    {
        public FeatureType()
        {
            Feature = new HashSet<Feature>();
        }

        public int Id { get; set; }
        public string TypeValue { get; set; }

        public virtual ICollection<Feature> Feature { get; set; }
    }
}
