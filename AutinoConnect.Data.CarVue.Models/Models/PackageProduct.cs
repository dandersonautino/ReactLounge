using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class PackageProduct
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int ProductId { get; set; }
        public int SaleQuantity { get; set; }
        public decimal SaleValue { get; set; }
        public string SaleCurrencyCode { get; set; }
        public int SaleAccountId { get; set; }
        public int SaleTaxGroupId { get; set; }
        public int PurchaseQuantity { get; set; }
        public decimal PurchaseValue { get; set; }
        public string PurchaseCurrencyCode { get; set; }
        public int PurchaseAccountId { get; set; }
        public int PurchaseTaxGroupId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual Package Package { get; set; }
        public virtual Product Product { get; set; }
        public virtual Account PurchaseAccount { get; set; }
        public virtual CurrencyCode PurchaseCurrencyCodeNavigation { get; set; }
        public virtual TaxGroup PurchaseTaxGroup { get; set; }
        public virtual Account SaleAccount { get; set; }
        public virtual CurrencyCode SaleCurrencyCodeNavigation { get; set; }
        public virtual TaxGroup SaleTaxGroup { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
    }
}
