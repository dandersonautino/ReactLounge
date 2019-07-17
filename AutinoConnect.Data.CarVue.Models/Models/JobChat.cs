using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class JobChat
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int ContactId { get; set; }
        public string Message { get; set; }
        public DateTime? ReadDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual Job Job { get; set; }
    }
}
