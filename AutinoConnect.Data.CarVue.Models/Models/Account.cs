using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Account
    {
        public Account()
        {
            GarageDefaultAccount = new HashSet<GarageDefaultAccount>();
            Item = new HashSet<Item>();
            PackageProductPurchaseAccount = new HashSet<PackageProduct>();
            PackageProductSaleAccount = new HashSet<PackageProduct>();
            ProductPurchaseAccount = new HashSet<Product>();
            ProductSaleAccount = new HashSet<Product>();
            TaxRate = new HashSet<TaxRate>();
        }

        public int Id { get; set; }
        public int GarageId { get; set; }
        public int AccountTypeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual ICollection<GarageDefaultAccount> GarageDefaultAccount { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<PackageProduct> PackageProductPurchaseAccount { get; set; }
        public virtual ICollection<PackageProduct> PackageProductSaleAccount { get; set; }
        public virtual ICollection<Product> ProductPurchaseAccount { get; set; }
        public virtual ICollection<Product> ProductSaleAccount { get; set; }
        public virtual ICollection<TaxRate> TaxRate { get; set; }
    }
}
