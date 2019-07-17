using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ContactCommunicationMethod
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int CommunicationMethodId { get; set; }
        public int CommunicationMethodTypeId { get; set; }
        public int OrderBy { get; set; }
        public bool IsPrimary { get; set; }
        public int? MapReferenceContainerId { get; set; }

        public virtual CommunicationMethodType CommunicationMethodType { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
    }
}
