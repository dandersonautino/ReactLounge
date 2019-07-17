using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryPartnerGarageUser
    {
        public int Id { get; set; }
        public int EnquiryPartnerId { get; set; }
        public int GarageId { get; set; }
        public int GarageUserId { get; set; }
        public Guid GarageUserRef { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual GarageUser GarageUser { get; set; }
    }
}
