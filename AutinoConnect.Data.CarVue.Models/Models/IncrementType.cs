using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class IncrementType
    {
        public IncrementType()
        {
            GarageIncrement = new HashSet<GarageIncrement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GarageIncrement> GarageIncrement { get; set; }
    }
}
