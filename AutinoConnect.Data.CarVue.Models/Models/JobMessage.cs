using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class JobMessage
    {
        public JobMessage()
        {
            LoungeJob = new HashSet<LoungeJob>();
            MessageReminderJobMessage = new HashSet<MessageReminderJobMessage>();
        }

        public int Id { get; set; }
        public int MessageDeliveryMechanism { get; set; }
        public int JobMessageType { get; set; }
        public int JobId { get; set; }
        public int ContactId { get; set; }
        public string ContactAddress { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public int? StatusId { get; set; }
        public string StatusMessage { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string MetaData { get; set; }
        public string Attachment { get; set; }
        public string Content { get; set; }
        public DateTime? ReadDate { get; set; }
        public DateTime? CustomerReadDate { get; set; }
        public int? ActionedBy { get; set; }
        public DateTime? ActionedDate { get; set; }
        public bool IsHidden { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual Job Job { get; set; }
        public virtual ICollection<LoungeJob> LoungeJob { get; set; }
        public virtual ICollection<MessageReminderJobMessage> MessageReminderJobMessage { get; set; }
    }
}
