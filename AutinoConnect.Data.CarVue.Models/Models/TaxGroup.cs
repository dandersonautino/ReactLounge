using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class TaxGroup
    {
        public TaxGroup()
        {
            GarageDefaultTaxGroup = new HashSet<GarageDefaultTaxGroup>();
            Item = new HashSet<Item>();
            PackageProductPurchaseTaxGroup = new HashSet<PackageProduct>();
            PackageProductSaleTaxGroup = new HashSet<PackageProduct>();
            ProductPurchaseTaxGroup = new HashSet<Product>();
            ProductSaleTaxGroup = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public bool IsSales { get; set; }
        public bool IsRevenue { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? DeletedBy { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual ICollection<GarageDefaultTaxGroup> GarageDefaultTaxGroup { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<PackageProduct> PackageProductPurchaseTaxGroup { get; set; }
        public virtual ICollection<PackageProduct> PackageProductSaleTaxGroup { get; set; }
        public virtual ICollection<Product> ProductPurchaseTaxGroup { get; set; }
        public virtual ICollection<Product> ProductSaleTaxGroup { get; set; }
    }
}
