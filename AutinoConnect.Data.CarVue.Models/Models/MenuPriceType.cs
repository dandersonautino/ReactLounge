using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class MenuPriceType
    {
        public MenuPriceType()
        {
            GarageEnquiryPartnerMenuPrice = new HashSet<GarageEnquiryPartnerMenuPrice>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<GarageEnquiryPartnerMenuPrice> GarageEnquiryPartnerMenuPrice { get; set; }
    }
}
