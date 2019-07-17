using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class CommunicationMethodType
    {
        public CommunicationMethodType()
        {
            CommunicationMethod = new HashSet<CommunicationMethod>();
            ContactCommunicationMethod = new HashSet<ContactCommunicationMethod>();
            GarageCommunicationMethod = new HashSet<GarageCommunicationMethod>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ReplicationId { get; set; }

        public virtual ICollection<CommunicationMethod> CommunicationMethod { get; set; }
        public virtual ICollection<ContactCommunicationMethod> ContactCommunicationMethod { get; set; }
        public virtual ICollection<GarageCommunicationMethod> GarageCommunicationMethod { get; set; }
    }
}
