using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class CustomerLoungeImportHistory
    {
        public CustomerLoungeImportHistory()
        {
            CustomerLoungeImportHistoryLog = new HashSet<CustomerLoungeImportHistoryLog>();
        }

        public Guid Id { get; set; }
        public int GarageId { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime? DateCompleted { get; set; }

        public virtual ICollection<CustomerLoungeImportHistoryLog> CustomerLoungeImportHistoryLog { get; set; }
    }
}
