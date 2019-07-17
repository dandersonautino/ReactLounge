using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ContactAddress
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public int? MapReferenceContainerId { get; set; }

        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
    }
}
