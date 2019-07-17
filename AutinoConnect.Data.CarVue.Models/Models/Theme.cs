using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Theme
    {
        public Theme()
        {
            EnquiryPartnerTheme = new HashSet<EnquiryPartnerTheme>();
            GarageTheme = new HashSet<GarageTheme>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ThemeTypeId { get; set; }
        public int ThemeGroupId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public string EmailTemplateLabel { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual ThemeGroup ThemeGroup { get; set; }
        public virtual ThemeType ThemeType { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual ICollection<EnquiryPartnerTheme> EnquiryPartnerTheme { get; set; }
        public virtual ICollection<GarageTheme> GarageTheme { get; set; }
    }
}
