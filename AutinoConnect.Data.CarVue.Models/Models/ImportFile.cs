using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ImportFile
    {
        public ImportFile()
        {
            ImportFileEvent = new HashSet<ImportFileEvent>();
        }

        public int Id { get; set; }
        public string FileName { get; set; }
        public int GarageId { get; set; }
        public string Status { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual ImportFileStatus StatusNavigation { get; set; }
        public virtual ICollection<ImportFileEvent> ImportFileEvent { get; set; }
    }
}
