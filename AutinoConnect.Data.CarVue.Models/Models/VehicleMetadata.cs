using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class VehicleMetadata
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int MetadataTypeId { get; set; }
        public string Value { get; set; }

        public virtual MetadataType MetadataType { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
