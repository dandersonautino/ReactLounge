using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageCommunicationMethod
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int CommunicationMethodId { get; set; }
        public int CommunicationMethodTypeId { get; set; }

        public virtual CommunicationMethodType CommunicationMethodType { get; set; }
        public virtual Garage Garage { get; set; }
    }
}
