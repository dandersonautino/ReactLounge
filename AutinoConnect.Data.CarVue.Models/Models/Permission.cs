using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Permission
    {
        public Permission()
        {
            GarageUser = new HashSet<GarageUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ReplicationId { get; set; }

        public virtual ICollection<GarageUser> GarageUser { get; set; }
    }
}
