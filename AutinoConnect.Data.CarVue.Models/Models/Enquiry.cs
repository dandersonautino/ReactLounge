using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Enquiry
    {
        public Enquiry()
        {
            EnquiryMessage = new HashSet<EnquiryMessage>();
            EnquiryMetaData = new HashSet<EnquiryMetaData>();
            EnquiryPackageInfo = new HashSet<EnquiryPackageInfo>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public int? EnquiryPartnerId { get; set; }
        public DateTime EnquiryPreferredBookingDateTime { get; set; }
        public Guid EnquiryRef { get; set; }
        public Guid? ContactRef { get; set; }
        public string ContactTitle { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactTel { get; set; }
        public string ContactMobile { get; set; }
        public Guid? VehicleRef { get; set; }
        public string VehicleRegNo { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleDerivative { get; set; }
        public int? JobId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? AcceptedBy { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public int? DeclinedBy { get; set; }
        public DateTime? DeclinedDate { get; set; }
        public DateTime? ProposedStart { get; set; }
        public int? ProposedBy { get; set; }
        public DateTime? ProposedEnd { get; set; }
        public string VehicleVin { get; set; }

        public virtual GarageUser AcceptedByNavigation { get; set; }
        public virtual GarageUser DeclinedByNavigation { get; set; }
        public virtual EnquiryPartner EnquiryPartner { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual Job Job { get; set; }
        public virtual ICollection<EnquiryMessage> EnquiryMessage { get; set; }
        public virtual ICollection<EnquiryMetaData> EnquiryMetaData { get; set; }
        public virtual ICollection<EnquiryPackageInfo> EnquiryPackageInfo { get; set; }
    }
}
