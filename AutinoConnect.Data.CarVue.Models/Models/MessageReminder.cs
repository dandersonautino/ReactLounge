using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class MessageReminder
    {
        public MessageReminder()
        {
            MessageReminderInternalNote = new HashSet<MessageReminderInternalNote>();
            MessageReminderJobMessage = new HashSet<MessageReminderJobMessage>();
            MessageReminderRepairMessage = new HashSet<MessageReminderRepairMessage>();
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime ReminderDate { get; set; }
        public DateTime? EventDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? DeletedBy { get; set; }
        public int? JobId { get; set; }
        public int? ActionedBy { get; set; }
        public DateTime? ActionedDate { get; set; }

        public virtual Job Job { get; set; }
        public virtual ICollection<MessageReminderInternalNote> MessageReminderInternalNote { get; set; }
        public virtual ICollection<MessageReminderJobMessage> MessageReminderJobMessage { get; set; }
        public virtual ICollection<MessageReminderRepairMessage> MessageReminderRepairMessage { get; set; }
    }
}
