using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FileLinkHistory
    {
        public int Id { get; set; }
        public int FileLinkId { get; set; }
        public string BlobName { get; set; }
        public int FileExtensionId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] Thumbnail { get; set; }
        public bool Reverted { get; set; }
        public DateTime? CustomerReadDate { get; set; }

        public virtual FileExtension FileExtension { get; set; }
        public virtual FileLink FileLink { get; set; }
    }
}
