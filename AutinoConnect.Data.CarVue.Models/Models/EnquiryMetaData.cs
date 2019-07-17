using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryMetaData
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int EnquiryId { get; set; }

        public virtual Enquiry Enquiry { get; set; }
    }
}
