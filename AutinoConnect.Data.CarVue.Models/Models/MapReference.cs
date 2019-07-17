using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class MapReference
    {
        public int MapId { get; set; }
        public int MapReferenceContainerId { get; set; }

        public virtual Map Map { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
    }
}
