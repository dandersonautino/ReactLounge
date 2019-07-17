using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class RepairMessage
    {
        public RepairMessage()
        {
            MessageReminderRepairMessage = new HashSet<MessageReminderRepairMessage>();
        }

        public int Id { get; set; }
        public int JobId { get; set; }
        public int ContactId { get; set; }
        public int PackageId { get; set; }
        public string Content { get; set; }
        public DateTime? ActionedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ReadDate { get; set; }
        public string MetaData { get; set; }
        public int? ActionedBy { get; set; }
        public bool Status { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual Job Job { get; set; }
        public virtual Package Package { get; set; }
        public virtual ICollection<MessageReminderRepairMessage> MessageReminderRepairMessage { get; set; }
    }
}
