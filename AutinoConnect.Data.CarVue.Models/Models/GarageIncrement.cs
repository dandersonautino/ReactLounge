using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageIncrement
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int IncrementTypeId { get; set; }
        public int StartNumber { get; set; }
        public string StartPrefix { get; set; }
        public int NextNumber { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual IncrementType IncrementType { get; set; }
    }
}
