using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            ContactContactType = new HashSet<ContactContactType>();
            VehicleContactHistory = new HashSet<VehicleContactHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ContactContactType> ContactContactType { get; set; }
        public virtual ICollection<VehicleContactHistory> VehicleContactHistory { get; set; }
    }
}
