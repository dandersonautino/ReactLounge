using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ApiPartnerIntegrationModifiers
    {
        public int Id { get; set; }
        public int AzureRegion { get; set; }
        public bool AutoCreateUsers { get; set; }
        public int NoOfDefaultResources { get; set; }
        public bool SendOnlineBookingViaBus { get; set; }

        public virtual EnquiryPartner IdNavigation { get; set; }
    }
}
