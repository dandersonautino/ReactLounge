using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ImportStaging
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Postcode { get; set; }
        public string Reg { get; set; }
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Derivative { get; set; }
        public string RepairType { get; set; }
        public string RepairName { get; set; }
        public string RepairDescription { get; set; }
        public decimal? RepairAllocatededTime { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Value { get; set; }
        public int? Dmsid { get; set; }
        public int? DmscustomerId { get; set; }
        public int? DmsvehicleId { get; set; }
        public int? DmsrepairId { get; set; }
        public string Dmsadvisor { get; set; }
        public int? DmsadvisorId { get; set; }
        public Guid? CustomerLoungeImportHistoryId { get; set; }
        public Guid? ImportStagingHeaderId { get; set; }
        public string VehicleFuel { get; set; }
    }
}
