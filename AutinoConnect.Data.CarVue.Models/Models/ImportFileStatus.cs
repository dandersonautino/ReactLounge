using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ImportFileStatus
    {
        public ImportFileStatus()
        {
            ImportFile = new HashSet<ImportFile>();
        }

        public string Status { get; set; }

        public virtual ICollection<ImportFile> ImportFile { get; set; }
    }
}
