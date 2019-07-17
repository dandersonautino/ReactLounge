using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ImportStagingHeaderStatus
    {
        public ImportStagingHeaderStatus()
        {
            ImportStagingHeader = new HashSet<ImportStagingHeader>();
        }

        public string Status { get; set; }

        public virtual ICollection<ImportStagingHeader> ImportStagingHeader { get; set; }
    }
}
