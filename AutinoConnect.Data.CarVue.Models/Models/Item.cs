using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public int GarageItemTypeId { get; set; }
        public int AccountId { get; set; }
        public int TaxGroupId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Value { get; set; }
        public string CurrencyCode { get; set; }
        public decimal DiscountPercentage { get; set; }
        public int JobId { get; set; }
        public int? RepairId { get; set; }
        public int? ProductId { get; set; }
        public int? MapReferenceContainerId { get; set; }
        public Guid? ReplicationId { get; set; }

        public virtual Account Account { get; set; }
        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual CurrencyCode CurrencyCodeNavigation { get; set; }
        public virtual Garage Garage { get; set; }
        public virtual GarageItemType GarageItemType { get; set; }
        public virtual Job Job { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Repair Repair { get; set; }
        public virtual TaxGroup TaxGroup { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
    }
}
