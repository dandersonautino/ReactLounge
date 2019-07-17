using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class DataOneModel
    {
        public DataOneModel()
        {
            DataOneDerivative = new HashSet<DataOneDerivative>();
        }

        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }

        public virtual DataOneMake Make { get; set; }
        public virtual ICollection<DataOneDerivative> DataOneDerivative { get; set; }
    }
}
