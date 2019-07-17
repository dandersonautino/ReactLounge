using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class KeeDerivative
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public string Name { get; set; }

        public virtual KeeModel Model { get; set; }
    }
}
