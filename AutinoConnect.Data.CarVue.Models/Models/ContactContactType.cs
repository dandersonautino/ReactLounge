using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ContactContactType
    {
        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ContactType ContactType { get; set; }
    }
}
