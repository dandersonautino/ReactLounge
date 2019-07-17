using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class MetadataType
    {
        public MetadataType()
        {
            ContactMetadata = new HashSet<ContactMetadata>();
            EnquiryPartnerMetaData = new HashSet<EnquiryPartnerMetaData>();
            GarageMetaData = new HashSet<GarageMetaData>();
            GarageMetadataType = new HashSet<GarageMetadataType>();
            GarageUserMetaData = new HashSet<GarageUserMetaData>();
            JobMetaData = new HashSet<JobMetaData>();
            VehicleMetadata = new HashSet<VehicleMetadata>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MetadataCategoryId { get; set; }

        public virtual ICollection<ContactMetadata> ContactMetadata { get; set; }
        public virtual ICollection<EnquiryPartnerMetaData> EnquiryPartnerMetaData { get; set; }
        public virtual ICollection<GarageMetaData> GarageMetaData { get; set; }
        public virtual ICollection<GarageMetadataType> GarageMetadataType { get; set; }
        public virtual ICollection<GarageUserMetaData> GarageUserMetaData { get; set; }
        public virtual ICollection<JobMetaData> JobMetaData { get; set; }
        public virtual ICollection<VehicleMetadata> VehicleMetadata { get; set; }
    }
}
