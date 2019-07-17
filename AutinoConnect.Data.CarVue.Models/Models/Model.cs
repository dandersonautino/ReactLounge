using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Model
    {
        public Model()
        {
            Derivative = new HashSet<Derivative>();
            VehicleClassificationRelation = new HashSet<VehicleClassificationRelation>();
        }

        public int MakeId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Guid ReplicationId { get; set; }
        public Guid Ref { get; set; }
        public int Id { get; set; }

        public virtual Make Make { get; set; }
        public virtual ICollection<Derivative> Derivative { get; set; }
        public virtual ICollection<VehicleClassificationRelation> VehicleClassificationRelation { get; set; }
    }
}
