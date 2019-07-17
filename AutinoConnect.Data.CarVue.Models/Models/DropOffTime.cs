using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class DropOffTime
    {
        public DropOffTime()
        {
            DropOffTimeDayOfWeek = new HashSet<DropOffTimeDayOfWeek>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public DateTime Time { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual ICollection<DropOffTimeDayOfWeek> DropOffTimeDayOfWeek { get; set; }
    }
}
