using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class JobMetaData
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int MetadataTypeId { get; set; }
        public string Value { get; set; }

        public virtual Job Job { get; set; }
        public virtual MetadataType MetadataType { get; set; }
    }
}
