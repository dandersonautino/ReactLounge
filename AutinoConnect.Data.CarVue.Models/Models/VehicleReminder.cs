using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class VehicleReminder
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int ReminderTypeId { get; set; }
        public DateTime DateFor { get; set; }
        public DateTime? TriggerDate { get; set; }
    }
}
