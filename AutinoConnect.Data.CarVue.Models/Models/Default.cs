using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Default
    {
        public Default()
        {
            GarageDefaultAccount = new HashSet<GarageDefaultAccount>();
            GarageDefaultTaxGroup = new HashSet<GarageDefaultTaxGroup>();
            InverseDefaultType = new HashSet<Default>();
        }

        public int Id { get; set; }
        public int DefaultTypeId { get; set; }
        public string Name { get; set; }
        public bool System { get; set; }
        public bool Required { get; set; }
        public int? AccountClassId { get; set; }

        public virtual AccountClass AccountClass { get; set; }
        public virtual Default DefaultType { get; set; }
        public virtual ICollection<GarageDefaultAccount> GarageDefaultAccount { get; set; }
        public virtual ICollection<GarageDefaultTaxGroup> GarageDefaultTaxGroup { get; set; }
        public virtual ICollection<Default> InverseDefaultType { get; set; }
    }
}
