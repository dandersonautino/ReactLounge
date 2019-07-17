using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Summary
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int? EnquiryPartnerId { get; set; }
        public DateTime SummaryDate { get; set; }
        public int SummaryTypeId { get; set; }
        public decimal Value { get; set; }
        public int Count { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual EnquiryPartner EnquiryPartner { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual SummaryType SummaryType { get; set; }
    }
}
