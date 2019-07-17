using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageRepairType
    {
        public GarageRepairType()
        {
            Package = new HashSet<Package>();
            Repair = new HashSet<Repair>();
            ResourceRepairType = new HashSet<ResourceRepairType>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public int RepairTypeId { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public int? MapReferenceContainerId { get; set; }

        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
        public virtual RepairType RepairType { get; set; }
        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<Repair> Repair { get; set; }
        public virtual ICollection<ResourceRepairType> ResourceRepairType { get; set; }
    }
}
