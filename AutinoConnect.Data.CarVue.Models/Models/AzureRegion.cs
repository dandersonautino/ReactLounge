using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class AzureRegion
    {
        public AzureRegion()
        {
            Country = new HashSet<Country>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }

        public virtual ICollection<Country> Country { get; set; }
    }
}
