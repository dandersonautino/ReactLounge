using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ReminderType
    {
        public ReminderType()
        {
            GarageReminderType = new HashSet<GarageReminderType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ReminderCategoryId { get; set; }

        public virtual ICollection<GarageReminderType> GarageReminderType { get; set; }
    }
}
