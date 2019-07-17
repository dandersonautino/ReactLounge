using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class MessageReminderInternalNote
    {
        public int MessageReminderId { get; set; }
        public int InternalNoteId { get; set; }

        public virtual InternalNote InternalNote { get; set; }
        public virtual MessageReminder MessageReminder { get; set; }
    }
}
