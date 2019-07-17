using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Make
    {
        public Make()
        {
            Model = new HashSet<Model>();
        }

        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Guid ReplicationId { get; set; }
        public Guid? Ref { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Model> Model { get; set; }
    }
}
