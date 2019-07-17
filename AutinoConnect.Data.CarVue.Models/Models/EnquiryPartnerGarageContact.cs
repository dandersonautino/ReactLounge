using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryPartnerGarageContact
    {
        public int Id { get; set; }
        public int EnquiryPartnerId { get; set; }
        public int GarageId { get; set; }
        public int ContactId { get; set; }
        public Guid ContactRef { get; set; }
    }
}
