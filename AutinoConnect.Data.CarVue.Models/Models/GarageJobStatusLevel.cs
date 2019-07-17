using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageJobStatusLevel
    {
        public GarageJobStatusLevel()
        {
            Job = new HashSet<Job>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public int JobStatusLevelId { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Colour { get; set; }
        public int OrderBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ReplicationId { get; set; }
        public int? MapReferenceContainerId { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual JobStatusLevel JobStatusLevel { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
        public virtual ICollection<Job> Job { get; set; }
    }
}
