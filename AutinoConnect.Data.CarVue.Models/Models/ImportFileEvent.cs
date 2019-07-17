using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ImportFileEvent
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public string EventDetail { get; set; }

        public virtual ImportFile File { get; set; }
    }
}
