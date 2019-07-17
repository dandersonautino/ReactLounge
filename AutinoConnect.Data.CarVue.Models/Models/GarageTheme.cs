using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageTheme
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int ThemeTypeId { get; set; }
        public int ThemeGroupId { get; set; }
        public int ThemeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual Theme Theme { get; set; }
        public virtual ThemeGroup ThemeGroup { get; set; }
        public virtual ThemeType ThemeType { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
    }
}
