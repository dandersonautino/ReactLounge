using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ContactMetadata
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int MetadataTypeId { get; set; }
        public string Value { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual MetadataType MetadataType { get; set; }
    }
}
