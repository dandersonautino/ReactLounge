using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class CustomerLoungeImportHistoryLog
    {
        public Guid Id { get; set; }
        public Guid CustomerLoungeImportHistoryId { get; set; }
        public DateTime DateLogged { get; set; }
        public string Message { get; set; }

        public virtual CustomerLoungeImportHistory CustomerLoungeImportHistory { get; set; }
    }
}
