using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class EnquiryPartnerMenuPrice
    {
        public int Id { get; set; }
        public Guid MenuPriceRef { get; set; }
        public int EnquiryPartnerPackageId { get; set; }
        public Guid VehicleClassificationId { get; set; }
        public decimal Value { get; set; }
        public int MenuPriceTypeId { get; set; }
        public string CurrencyCode { get; set; }

        public virtual EnquiryPartnerPackage EnquiryPartnerPackage { get; set; }
        public virtual VehicleClassification VehicleClassification { get; set; }
    }
}
