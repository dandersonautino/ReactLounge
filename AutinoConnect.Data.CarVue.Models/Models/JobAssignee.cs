using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class JobAssignee
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int GarageUserId { get; set; }
        public int PositionId { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public int? MapReferenceContainerId { get; set; }

        public virtual GarageUser GarageUser { get; set; }
        public virtual Job Job { get; set; }
        public virtual Position Position { get; set; }
    }
}
