﻿using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageMetadataType
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int MetadataTypeId { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual MetadataType MetadataType { get; set; }
    }
}
