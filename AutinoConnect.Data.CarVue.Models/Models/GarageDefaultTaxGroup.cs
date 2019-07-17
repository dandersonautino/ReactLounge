using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageDefaultTaxGroup
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int DefaultId { get; set; }
        public int TaxGroupId { get; set; }

        public virtual Default Default { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual TaxGroup TaxGroup { get; set; }
    }
}
