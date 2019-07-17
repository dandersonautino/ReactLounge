using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class InternalNote
    {
        public InternalNote()
        {
            MessageReminderInternalNote = new HashSet<MessageReminderInternalNote>();
        }

        public int Id { get; set; }
        public int JobId { get; set; }
        public string Note { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ActionedBy { get; set; }
        public DateTime? ActionedDate { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual Job Job { get; set; }
        public virtual ICollection<MessageReminderInternalNote> MessageReminderInternalNote { get; set; }
    }
}
