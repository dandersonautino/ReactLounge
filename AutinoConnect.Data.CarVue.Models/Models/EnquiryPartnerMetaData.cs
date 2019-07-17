using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryPartnerMetaData
    {
        public int Id { get; set; }
        public int EnquiryPartnerId { get; set; }
        public int MetadataTypeId { get; set; }
        public string Value { get; set; }

        public virtual EnquiryPartner EnquiryPartner { get; set; }
        public virtual MetadataType MetadataType { get; set; }
    }
}
