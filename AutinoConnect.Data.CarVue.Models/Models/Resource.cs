using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Resource
    {
        public Resource()
        {
            Repair = new HashSet<Repair>();
            ResourceAvailability = new HashSet<ResourceAvailability>();
            ResourceRepairType = new HashSet<ResourceRepairType>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public int OrderBy { get; set; }
        public Guid Ref { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual ICollection<Repair> Repair { get; set; }
        public virtual ICollection<ResourceAvailability> ResourceAvailability { get; set; }
        public virtual ICollection<ResourceRepairType> ResourceRepairType { get; set; }
    }
}
