using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FileLink
    {
        public FileLink()
        {
            FileLinkHistory = new HashSet<FileLinkHistory>();
        }

        public int Id { get; set; }
        public string FriendlyName { get; set; }
        public string Description { get; set; }
        public int FileGroupingId { get; set; }
        public bool RecentlyUpdated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int FilePermissionLevelId { get; set; }

        public virtual FileGrouping FileGrouping { get; set; }
        public virtual FilePermissionLevel FilePermissionLevel { get; set; }
        public virtual ICollection<FileLinkHistory> FileLinkHistory { get; set; }
    }
}
