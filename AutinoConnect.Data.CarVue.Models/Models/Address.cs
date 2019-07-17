using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Address
    {
        public Address()
        {
            BillingAccount = new HashSet<BillingAccount>();
            Garage = new HashSet<Garage>();
        }

        public int Id { get; set; }
        public int AddressTypeId { get; set; }
        public string AttentionTo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Postcode { get; set; }
        public int? CountryId { get; set; }
        public Guid ReplicationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual AddressType AddressType { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<BillingAccount> BillingAccount { get; set; }
        public virtual ICollection<Garage> Garage { get; set; }
    }
}
