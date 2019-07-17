using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class JobSuperStatusLevel
    {
        public JobSuperStatusLevel()
        {
            JobStatusLevel = new HashSet<JobStatusLevel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<JobStatusLevel> JobStatusLevel { get; set; }
    }
}
