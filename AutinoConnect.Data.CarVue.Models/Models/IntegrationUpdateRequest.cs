using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class IntegrationUpdateRequest
    {
        public int Id { get; set; }
        public string ReferenceContextId { get; set; }
        public string ReferenceContextType { get; set; }
        public int ReferenceObjectTypeId { get; set; }
        public int IntegrationTypeId { get; set; }
        public int GarageId { get; set; }

        public virtual Garage Garage { get; set; }
    }
}
