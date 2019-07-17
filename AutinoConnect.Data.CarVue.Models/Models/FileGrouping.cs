using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FileGrouping
    {
        public FileGrouping()
        {
            FileLink = new HashSet<FileLink>();
            Job = new HashSet<Job>();
        }

        public int Id { get; set; }
        public int AssociatedId { get; set; }
        public int ReferenceObjectTypeId { get; set; }

        public virtual ReferenceObjectType ReferenceObjectType { get; set; }
        public virtual ICollection<FileLink> FileLink { get; set; }
        public virtual ICollection<Job> Job { get; set; }
    }
}
