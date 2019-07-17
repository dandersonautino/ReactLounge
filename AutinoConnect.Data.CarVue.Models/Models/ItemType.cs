using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ItemType
    {
        public ItemType()
        {
            GarageItemType = new HashSet<GarageItemType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GarageItemType> GarageItemType { get; set; }
    }
}
