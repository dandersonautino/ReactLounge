using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageCampaign
    {
        public GarageCampaign()
        {
            GarageCampaignEvent = new HashSet<GarageCampaignEvent>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public string Name { get; set; }
        public int CampaignTypeId { get; set; }
        public int TimeInterval { get; set; }
        public int IntervalTypeId { get; set; }
        public bool? Enabled { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Message { get; set; }
        public bool IsCustom { get; set; }

        public virtual CampaignType CampaignType { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual IntervalType IntervalType { get; set; }
        public virtual ICollection<GarageCampaignEvent> GarageCampaignEvent { get; set; }
    }
}
