using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class BillingAccount
    {
        public BillingAccount()
        {
            BillingAccountInvoicee = new HashSet<BillingAccountInvoicee>();
            Garage = new HashSet<Garage>();
        }

        public int Id { get; set; }
        public int PartnerId { get; set; }
        public string Name { get; set; }
        public string CompanyNumber { get; set; }
        public string TaxNumber { get; set; }
        public bool IsTaxVerified { get; set; }
        public int BillingAccountStatusId { get; set; }
        public int? AddressId { get; set; }
        public int? CommunicationMethodId { get; set; }
        public bool ShareContacts { get; set; }
        public bool ShareVehicles { get; set; }
        public Guid ReplicationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual BillingAccountStatus BillingAccountStatus { get; set; }
        public virtual CommunicationMethod CommunicationMethod { get; set; }
        public virtual Partner Partner { get; set; }
        public virtual ICollection<BillingAccountInvoicee> BillingAccountInvoicee { get; set; }
        public virtual ICollection<Garage> Garage { get; set; }
    }
}
