using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class VehicleContactHistory
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? MapReferenceContainerId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
