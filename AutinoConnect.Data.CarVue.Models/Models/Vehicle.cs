using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            EnquiryPartnerGarageVehicle = new HashSet<EnquiryPartnerGarageVehicle>();
            GarageVehicle = new HashSet<GarageVehicle>();
            Job = new HashSet<Job>();
            VehicleContactHistory = new HashSet<VehicleContactHistory>();
            VehicleMetadata = new HashSet<VehicleMetadata>();
            VehicleMileageHistory = new HashSet<VehicleMileageHistory>();
        }

        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Derivative { get; set; }
        public string RegNo { get; set; }
        public string VinNo { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? ProductionDate { get; set; }
        public int? FuelTypeId { get; set; }
        public string BodyStyle { get; set; }
        public string Doors { get; set; }
        public string Colour { get; set; }
        public string Trim { get; set; }
        public string Gearbox { get; set; }
        public string GearboxNo { get; set; }
        public string EngineNo { get; set; }
        public string EngineCode { get; set; }
        public decimal? EngineCapacity { get; set; }
        public int? OdometerMeasureTypeId { get; set; }
        public int? OdometerReading { get; set; }
        public string Power { get; set; }
        public int? PowerTypeId { get; set; }
        public string DriveType { get; set; }
        public int? YearOfManufacture { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public Guid ReplicationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? MapReferenceContainerId { get; set; }

        public virtual GarageUser CreatedByNavigation { get; set; }
        public virtual GarageUser DeletedByNavigation { get; set; }
        public virtual FuelType FuelType { get; set; }
        public virtual MapReferenceContainer MapReferenceContainer { get; set; }
        public virtual OdometerMeasureType OdometerMeasureType { get; set; }
        public virtual PowerType PowerType { get; set; }
        public virtual GarageUser UpdatedByNavigation { get; set; }
        public virtual ICollection<EnquiryPartnerGarageVehicle> EnquiryPartnerGarageVehicle { get; set; }
        public virtual ICollection<GarageVehicle> GarageVehicle { get; set; }
        public virtual ICollection<Job> Job { get; set; }
        public virtual ICollection<VehicleContactHistory> VehicleContactHistory { get; set; }
        public virtual ICollection<VehicleMetadata> VehicleMetadata { get; set; }
        public virtual ICollection<VehicleMileageHistory> VehicleMileageHistory { get; set; }
    }
}
