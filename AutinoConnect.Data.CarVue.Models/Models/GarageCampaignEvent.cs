using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageCampaignEvent
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int GarageCampaignId { get; set; }
        public int JobId { get; set; }
        public bool Procesed { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual GarageCampaign GarageCampaign { get; set; }
        public virtual Job Job { get; set; }
    }
}
