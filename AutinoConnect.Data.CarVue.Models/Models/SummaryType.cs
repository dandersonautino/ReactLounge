using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class SummaryType
    {
        public SummaryType()
        {
            Summary = new HashSet<Summary>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Summary> Summary { get; set; }
    }
}
