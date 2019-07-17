using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class CurrencyCode
    {
        public CurrencyCode()
        {
            CountryDefaults = new HashSet<CountryDefaults>();
            Garage = new HashSet<Garage>();
            GarageEnquiryPartnerPackage = new HashSet<GarageEnquiryPartnerPackage>();
            Item = new HashSet<Item>();
            Package = new HashSet<Package>();
            PackageProductPurchaseCurrencyCodeNavigation = new HashSet<PackageProduct>();
            PackageProductSaleCurrencyCodeNavigation = new HashSet<PackageProduct>();
            ProductPurchaseCurrencyCodeNavigation = new HashSet<Product>();
            ProductSaleCurrencyCodeNavigation = new HashSet<Product>();
        }

        public int Isocode { get; set; }
        public string CurrencyCode1 { get; set; }
        public string Description { get; set; }
        public bool Supported { get; set; }

        public virtual ICollection<CountryDefaults> CountryDefaults { get; set; }
        public virtual ICollection<Garage> Garage { get; set; }
        public virtual ICollection<GarageEnquiryPartnerPackage> GarageEnquiryPartnerPackage { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<PackageProduct> PackageProductPurchaseCurrencyCodeNavigation { get; set; }
        public virtual ICollection<PackageProduct> PackageProductSaleCurrencyCodeNavigation { get; set; }
        public virtual ICollection<Product> ProductPurchaseCurrencyCodeNavigation { get; set; }
        public virtual ICollection<Product> ProductSaleCurrencyCodeNavigation { get; set; }
    }
}
