using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageUserPosition
    {
        public int GarageUserId { get; set; }
        public int PositionId { get; set; }

        public virtual GarageUser GarageUser { get; set; }
        public virtual Position Position { get; set; }
    }
}
