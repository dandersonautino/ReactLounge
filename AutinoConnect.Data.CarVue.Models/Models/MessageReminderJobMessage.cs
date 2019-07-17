using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class MessageReminderJobMessage
    {
        public int MessageReminderId { get; set; }
        public int JobMessageId { get; set; }

        public virtual JobMessage JobMessage { get; set; }
        public virtual MessageReminder MessageReminder { get; set; }
    }
}
