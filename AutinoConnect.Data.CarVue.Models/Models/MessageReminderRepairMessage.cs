using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class MessageReminderRepairMessage
    {
        public int MessageReminderId { get; set; }
        public int RepairMessageId { get; set; }

        public virtual MessageReminder MessageReminder { get; set; }
        public virtual RepairMessage RepairMessage { get; set; }
    }
}
