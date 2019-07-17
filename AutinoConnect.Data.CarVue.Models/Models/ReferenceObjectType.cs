using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ReferenceObjectType
    {
        public ReferenceObjectType()
        {
            FileGrouping = new HashSet<FileGrouping>();
            Map = new HashSet<Map>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FileGrouping> FileGrouping { get; set; }
        public virtual ICollection<Map> Map { get; set; }
    }
}
