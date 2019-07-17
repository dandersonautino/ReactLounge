using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class DataOneMake
    {
        public DataOneMake()
        {
            DataOneModel = new HashSet<DataOneModel>();
        }

        public int Id { get; set; }
        public int YearId { get; set; }
        public string Name { get; set; }

        public virtual DataOneYear Year { get; set; }
        public virtual ICollection<DataOneModel> DataOneModel { get; set; }
    }
}
