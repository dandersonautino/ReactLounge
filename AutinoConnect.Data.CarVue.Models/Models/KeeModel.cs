using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class KeeModel
    {
        public KeeModel()
        {
            KeeDerivative = new HashSet<KeeDerivative>();
        }

        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }

        public virtual KeeMake Make { get; set; }
        public virtual ICollection<KeeDerivative> KeeDerivative { get; set; }
    }
}
