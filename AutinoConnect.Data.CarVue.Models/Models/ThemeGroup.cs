using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ThemeGroup
    {
        public ThemeGroup()
        {
            EnquiryPartnerTheme = new HashSet<EnquiryPartnerTheme>();
            GarageTheme = new HashSet<GarageTheme>();
            Theme = new HashSet<Theme>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual ICollection<EnquiryPartnerTheme> EnquiryPartnerTheme { get; set; }
        public virtual ICollection<GarageTheme> GarageTheme { get; set; }
        public virtual ICollection<Theme> Theme { get; set; }
    }
}
