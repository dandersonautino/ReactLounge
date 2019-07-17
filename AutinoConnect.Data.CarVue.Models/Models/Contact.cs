using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Contact
    {
        public Contact()
        {
            ContactCommunicationMethod = new HashSet<ContactCommunicationMethod>();
            ContactContactType = new HashSet<ContactContactType>();
            ContactMetadata = new HashSet<ContactMetadata>();
            GarageContact = new HashSet<GarageContact>();
            Job = new HashSet<Job>();
            JobChat = new HashSet<JobChat>();
            VehicleContactHistory = new HashSet<VehicleContactHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CContactTypes { get; set; }
        public Guid ReplicationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? MapReferenceContainerId { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual ICollection<ContactCommunicationMethod> ContactCommunicationMethod { get; set; }
        public virtual ICollection<ContactContactType> ContactContactType { get; set; }
        public virtual ICollection<ContactMetadata> ContactMetadata { get; set; }
        public virtual ICollection<GarageContact> GarageContact { get; set; }
        public virtual ICollection<Job> Job { get; set; }
        public virtual ICollection<JobChat> JobChat { get; set; }
        public virtual ICollection<VehicleContactHistory> VehicleContactHistory { get; set; }
    }
}
