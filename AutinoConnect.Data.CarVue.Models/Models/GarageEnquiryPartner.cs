using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageEnquiryPartner
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int EnquiryPartnerId { get; set; }
        public Guid GarageRef { get; set; }
        public bool IsActive { get; set; }
        public bool? IsPending { get; set; }
        public Guid? GarageToken { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual EnquiryPartner EnquiryPartner { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual GarageUser ModifiedByNavigation { get; set; }
    }
}
