using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class AddonPackage
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int AddonPackageId { get; set; }

        public virtual Package Package { get; set; }
    }
}
