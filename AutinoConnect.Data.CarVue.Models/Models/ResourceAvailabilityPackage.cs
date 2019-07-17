using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ResourceAvailabilityPackage
    {
        public int Id { get; set; }
        public int ResourceAvailabilityId { get; set; }
        public int PackageId { get; set; }
        public TimeSpan? EarliestStartTime { get; set; }
        public TimeSpan? LastStartTime { get; set; }

        public virtual Package Package { get; set; }
        public virtual ResourceAvailability ResourceAvailability { get; set; }
    }
}
