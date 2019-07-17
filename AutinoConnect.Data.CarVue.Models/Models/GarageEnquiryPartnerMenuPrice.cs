using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class GarageEnquiryPartnerMenuPrice
    {
        public int Id { get; set; }
        public Guid MenuPriceRef { get; set; }
        public int GarageEnquiryPartnerPackageId { get; set; }
        public Guid VehicleClassificationId { get; set; }
        public decimal Value { get; set; }
        public int MenuPriceTypeId { get; set; }
        public string CurrencyCode { get; set; }

        public virtual GarageEnquiryPartnerPackage GarageEnquiryPartnerPackage { get; set; }
        public virtual MenuPriceType MenuPriceType { get; set; }
        public virtual VehicleClassification VehicleClassification { get; set; }
    }
}
