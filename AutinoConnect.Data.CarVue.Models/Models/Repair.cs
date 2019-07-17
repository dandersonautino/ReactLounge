using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Repair
    {
        public Repair()
        {
            Item = new HashSet<Item>();
        }

        public int Id { get; set; }
        public int JobId { get; set; }
        public string RepairName { get; set; }
        public int GarageRepairTypeId { get; set; }
        public int? PackageId { get; set; }
        public int? ResourceId { get; set; }
        public DateTime? In { get; set; }
        public DateTime? Out { get; set; }
        public string RequestedNote { get; set; }
        public string RequiredNote { get; set; }
        public string TechnicianNote { get; set; }
        public decimal BookedTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public int? MapReferenceContainerId { get; set; }
        public int? FileGroupingId { get; set; }
        public Guid? ReplicationId { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual GarageRepairType GarageRepairType { get; set; }
        public virtual Job Job { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
        public virtual Package Package { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual ICollection<Item> Item { get; set; }
    }
}
