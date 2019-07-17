using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FileExtension
    {
        public FileExtension()
        {
            FileLinkHistory = new HashSet<FileLinkHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FileLinkHistory> FileLinkHistory { get; set; }
    }
}
