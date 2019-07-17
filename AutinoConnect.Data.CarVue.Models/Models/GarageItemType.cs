using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageItemType
    {
        public GarageItemType()
        {
            Item = new HashSet<Item>();
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public int ItemTypeId { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
