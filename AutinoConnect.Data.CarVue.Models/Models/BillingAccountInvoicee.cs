using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class BillingAccountInvoicee
    {
        public int Id { get; set; }
        public int BillingAccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid ReplicationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual BillingAccount BillingAccount { get; set; }
        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
    }
}
