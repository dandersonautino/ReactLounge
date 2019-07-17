using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ImportStagingHeader
    {
        public Guid Id { get; set; }
        public int GarageId { get; set; }
        public int FileId { get; set; }
        public string Status { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual ImportStagingHeaderStatus StatusNavigation { get; set; }
    }
}
