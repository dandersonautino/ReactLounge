using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageUserMetaData
    {
        public int Id { get; set; }
        public int GarageUserId { get; set; }
        public int MetadataTypeId { get; set; }
        public string Value { get; set; }

        public virtual GarageUser GarageUser { get; set; }
        public virtual MetadataType MetadataType { get; set; }
    }
}
