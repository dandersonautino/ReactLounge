using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ThemeType
    {
        public ThemeType()
        {
            EnquiryPartnerTheme = new HashSet<EnquiryPartnerTheme>();
            GarageTheme = new HashSet<GarageTheme>();
            Theme = new HashSet<Theme>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EnquiryPartnerTheme> EnquiryPartnerTheme { get; set; }
        public virtual ICollection<GarageTheme> GarageTheme { get; set; }
        public virtual ICollection<Theme> Theme { get; set; }
    }
}
