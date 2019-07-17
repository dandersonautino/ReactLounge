using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryMessage
    {
        public int Id { get; set; }
        public int MessageDeliveryMechanism { get; set; }
        public int JobMessageType { get; set; }
        public int EnquiryId { get; set; }
        public string ContactAddress { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public int? StatusId { get; set; }
        public string StatusMessage { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string MetaData { get; set; }
        public string Content { get; set; }
        public DateTime? ReadDate { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual Enquiry Enquiry { get; set; }
    }
}
