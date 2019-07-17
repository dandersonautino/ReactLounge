using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ResourceAvailability
    {
        public ResourceAvailability()
        {
            ResourceAvailabilityPackage = new HashSet<ResourceAvailabilityPackage>();
        }

        public int Id { get; set; }
        public int ResourceId { get; set; }
        public byte DayOfWeek { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int? MaxQuantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual ICollection<ResourceAvailabilityPackage> ResourceAvailabilityPackage { get; set; }
    }
}
