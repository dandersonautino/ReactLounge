using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class JobStatusLevel
    {
        public JobStatusLevel()
        {
            GarageJobStatusLevel = new HashSet<GarageJobStatusLevel>();
        }

        public int Id { get; set; }
        public int JobSuperStatusLevelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual JobSuperStatusLevel JobSuperStatusLevel { get; set; }
        public virtual ICollection<GarageJobStatusLevel> GarageJobStatusLevel { get; set; }
    }
}
