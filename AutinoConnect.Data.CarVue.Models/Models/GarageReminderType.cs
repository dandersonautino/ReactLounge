using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageReminderType
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int ReminderTypeId { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual ReminderType ReminderType { get; set; }
    }
}
