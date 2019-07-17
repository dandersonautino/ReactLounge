using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Map
    {
        public Map()
        {
            MapReference = new HashSet<MapReference>();
        }

        public int Id { get; set; }
        public string ReferenceContext { get; set; }
        public string ReferenceContextType { get; set; }
        public int IntegrationTypeId { get; set; }
        public int ReferenceObjectTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public int RootGarageId { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual IntegrationType IntegrationType { get; set; }
        public virtual ReferenceObjectType ReferenceObjectType { get; set; }
        public virtual Garage RootGarage { get; set; }
        public virtual ICollection<MapReference> MapReference { get; set; }
    }
}
