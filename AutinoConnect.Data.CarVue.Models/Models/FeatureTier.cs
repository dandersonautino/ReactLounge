using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FeatureTier
    {
        public int Id { get; set; }
        public int FeatureId { get; set; }
        public int TierId { get; set; }

        public virtual Feature Feature { get; set; }
        public virtual Tier Tier { get; set; }
    }
}
