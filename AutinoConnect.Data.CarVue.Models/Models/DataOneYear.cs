using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class DataOneYear
    {
        public DataOneYear()
        {
            DataOneMake = new HashSet<DataOneMake>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DataOneMake> DataOneMake { get; set; }
    }
}
