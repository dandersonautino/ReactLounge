using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryPartnerGarageVehicle
    {
        public int Id { get; set; }
        public int EnquiryPartnerId { get; set; }
        public int GarageId { get; set; }
        public int VehicleId { get; set; }
        public Guid VehicleRef { get; set; }

        public virtual EnquiryPartner EnquiryPartner { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
