using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class MapReferenceContainer
    {
        public MapReferenceContainer()
        {
            Contact = new HashSet<Contact>();
            ContactAddress = new HashSet<ContactAddress>();
            ContactCommunicationMethod = new HashSet<ContactCommunicationMethod>();
            Garage = new HashSet<Garage>();
            GarageJobStatusLevel = new HashSet<GarageJobStatusLevel>();
            GarageRepairType = new HashSet<GarageRepairType>();
            Item = new HashSet<Item>();
            Job = new HashSet<Job>();
            MapReference = new HashSet<MapReference>();
            Repair = new HashSet<Repair>();
            Vehicle = new HashSet<Vehicle>();
            VehicleContactHistory = new HashSet<VehicleContactHistory>();
        }

        public int Id { get; set; }

        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<ContactAddress> ContactAddress { get; set; }
        public virtual ICollection<ContactCommunicationMethod> ContactCommunicationMethod { get; set; }
        public virtual ICollection<Garage> Garage { get; set; }
        public virtual ICollection<GarageJobStatusLevel> GarageJobStatusLevel { get; set; }
        public virtual ICollection<GarageRepairType> GarageRepairType { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<Job> Job { get; set; }
        public virtual ICollection<MapReference> MapReference { get; set; }
        public virtual ICollection<Repair> Repair { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        public virtual ICollection<VehicleContactHistory> VehicleContactHistory { get; set; }
    }
}
