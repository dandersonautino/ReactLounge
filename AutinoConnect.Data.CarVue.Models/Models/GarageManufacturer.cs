using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageManufacturer
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int ManufacturerId { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
