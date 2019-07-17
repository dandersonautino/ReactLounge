using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class CommunicationMethod
    {
        public CommunicationMethod()
        {
            BillingAccount = new HashSet<BillingAccount>();
        }

        public int Id { get; set; }
        public int CommunicationMethodTypeId { get; set; }
        public string Value { get; set; }
        public Guid ReplicationId { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual CommunicationMethodType CommunicationMethodType { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual ICollection<BillingAccount> BillingAccount { get; set; }
    }
}
