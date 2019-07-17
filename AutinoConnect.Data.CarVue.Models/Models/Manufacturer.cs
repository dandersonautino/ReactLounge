using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            GarageManufacturer = new HashSet<GarageManufacturer>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid Ref { get; set; }

        public virtual ICollection<GarageManufacturer> GarageManufacturer { get; set; }
    }
}
