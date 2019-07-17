using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Position
    {
        public Position()
        {
            GarageUserPosition = new HashSet<GarageUserPosition>();
            JobAssignee = new HashSet<JobAssignee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ReplicationId { get; set; }

        public virtual ICollection<GarageUserPosition> GarageUserPosition { get; set; }
        public virtual ICollection<JobAssignee> JobAssignee { get; set; }
    }
}
