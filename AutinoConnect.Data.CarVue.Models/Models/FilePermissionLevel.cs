using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FilePermissionLevel
    {
        public FilePermissionLevel()
        {
            FileLink = new HashSet<FileLink>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FileLink> FileLink { get; set; }
    }
}
