using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageOutOfOffice
    {
        public int GarageId { get; set; }
        public bool IsEnabled { get; set; }
        public string Smstext { get; set; }

        public virtual Garage Garage { get; set; }
    }
}
