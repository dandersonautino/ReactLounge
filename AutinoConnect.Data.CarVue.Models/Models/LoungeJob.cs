using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class LoungeJob
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int GarageId { get; set; }
        public DateTime ValidStart { get; set; }
        public DateTime? ValidEnd { get; set; }
        public Guid Reference { get; set; }
        public string AuthenticationCode { get; set; }
        public int? JobMessageId { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual Job Job { get; set; }
        public virtual JobMessage JobMessage { get; set; }
    }
}
