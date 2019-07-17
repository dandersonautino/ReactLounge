using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class RegistrationStatus
    {
        public RegistrationStatus()
        {
            Garage = new HashSet<Garage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Garage> Garage { get; set; }
    }
}
