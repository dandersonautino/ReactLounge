using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Job
    {
        public Job()
        {
            Enquiry = new HashSet<Enquiry>();
            GarageCampaignEvent = new HashSet<GarageCampaignEvent>();
            InternalNote = new HashSet<InternalNote>();
            Item = new HashSet<Item>();
            JobAssignee = new HashSet<JobAssignee>();
            JobChat = new HashSet<JobChat>();
            JobMessage = new HashSet<JobMessage>();
            JobMetaData = new HashSet<JobMetaData>();
            LoungeJob = new HashSet<LoungeJob>();
            MessageReminder = new HashSet<MessageReminder>();
            Repair = new HashSet<Repair>();
            RepairMessage = new HashSet<RepairMessage>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public int ContactId { get; set; }
        public int VehicleId { get; set; }
        public string Number { get; set; }
        public DateTime In { get; set; }
        public DateTime Out { get; set; }
        public DateTime? Estimated { get; set; }
        public DateTime? Completed { get; set; }
        public int GarageJobStatusLevelId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? ReadDate { get; set; }
        public int? MapReferenceContainerId { get; set; }
        public int? FileGroupingId { get; set; }
        public DateTime? DeclinedDate { get; set; }
        public int? DeclinedBy { get; set; }
        public string JobComment { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeclinedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual FileGrouping FileGrouping { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual GarageJobStatusLevel GarageJobStatusLevel { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<Enquiry> Enquiry { get; set; }
        public virtual ICollection<GarageCampaignEvent> GarageCampaignEvent { get; set; }
        public virtual ICollection<InternalNote> InternalNote { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<JobAssignee> JobAssignee { get; set; }
        public virtual ICollection<JobChat> JobChat { get; set; }
        public virtual ICollection<JobMessage> JobMessage { get; set; }
        public virtual ICollection<JobMetaData> JobMetaData { get; set; }
        public virtual ICollection<LoungeJob> LoungeJob { get; set; }
        public virtual ICollection<MessageReminder> MessageReminder { get; set; }
        public virtual ICollection<Repair> Repair { get; set; }
        public virtual ICollection<RepairMessage> RepairMessage { get; set; }
    }
}
