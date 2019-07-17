using Microsoft.EntityFrameworkCore;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class ACCarVueContext : DbContext
    {
        public ACCarVueContext()
        {
        }

        public ACCarVueContext(DbContextOptions<ACCarVueContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountClass> AccountClass { get; set; }
        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<AddonPackage> AddonPackage { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<ApiPartnerIntegrationModifiers> ApiPartnerIntegrationModifiers { get; set; }
        public virtual DbSet<AzureRegion> AzureRegion { get; set; }
        public virtual DbSet<BillingAccount> BillingAccount { get; set; }
        public virtual DbSet<BillingAccountInvoicee> BillingAccountInvoicee { get; set; }
        public virtual DbSet<BillingAccountStatus> BillingAccountStatus { get; set; }
        public virtual DbSet<CampaignType> CampaignType { get; set; }
        public virtual DbSet<CommunicationMethod> CommunicationMethod { get; set; }
        public virtual DbSet<CommunicationMethodType> CommunicationMethodType { get; set; }
        public virtual DbSet<CommunicationType> CommunicationType { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactAddress> ContactAddress { get; set; }
        public virtual DbSet<ContactCommunicationMethod> ContactCommunicationMethod { get; set; }
        public virtual DbSet<ContactContactType> ContactContactType { get; set; }
        public virtual DbSet<ContactMetadata> ContactMetadata { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryDefaults> CountryDefaults { get; set; }
        public virtual DbSet<CountryTaxRateTemplate> CountryTaxRateTemplate { get; set; }
        public virtual DbSet<CurrencyCode> CurrencyCode { get; set; }
        public virtual DbSet<CustomerLoungeImportHistory> CustomerLoungeImportHistory { get; set; }
        public virtual DbSet<CustomerLoungeImportHistoryLog> CustomerLoungeImportHistoryLog { get; set; }
        public virtual DbSet<DataOneDerivative> DataOneDerivative { get; set; }
        public virtual DbSet<DataOneMake> DataOneMake { get; set; }
        public virtual DbSet<DataOneModel> DataOneModel { get; set; }
        public virtual DbSet<DataOneYear> DataOneYear { get; set; }
        public virtual DbSet<DaysSinceMinDate> DaysSinceMinDate { get; set; }
        public virtual DbSet<Default> Default { get; set; }
        public virtual DbSet<DefaultType> DefaultType { get; set; }
        public virtual DbSet<Derivative> Derivative { get; set; }
        public virtual DbSet<DevicePlatform> DevicePlatform { get; set; }
        public virtual DbSet<DropOffTime> DropOffTime { get; set; }
        public virtual DbSet<DropOffTimeDayOfWeek> DropOffTimeDayOfWeek { get; set; }
        public virtual DbSet<Enquiry> Enquiry { get; set; }
        public virtual DbSet<EnquiryMessage> EnquiryMessage { get; set; }
        public virtual DbSet<EnquiryMetaData> EnquiryMetaData { get; set; }
        public virtual DbSet<EnquiryPackageInfo> EnquiryPackageInfo { get; set; }
        public virtual DbSet<EnquiryPartner> EnquiryPartner { get; set; }
        public virtual DbSet<EnquiryPartnerGarageContact> EnquiryPartnerGarageContact { get; set; }
        public virtual DbSet<EnquiryPartnerGarageUser> EnquiryPartnerGarageUser { get; set; }
        public virtual DbSet<EnquiryPartnerGarageVehicle> EnquiryPartnerGarageVehicle { get; set; }
        public virtual DbSet<EnquiryPartnerMenuPrice> EnquiryPartnerMenuPrice { get; set; }
        public virtual DbSet<EnquiryPartnerMetaData> EnquiryPartnerMetaData { get; set; }
        public virtual DbSet<EnquiryPartnerPackage> EnquiryPartnerPackage { get; set; }
        public virtual DbSet<EnquiryPartnerPackageMapping> EnquiryPartnerPackageMapping { get; set; }
        public virtual DbSet<EnquiryPartnerTheme> EnquiryPartnerTheme { get; set; }
        public virtual DbSet<Facilities> Facilities { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<FeatureCategory> FeatureCategory { get; set; }
        public virtual DbSet<FeatureConfig> FeatureConfig { get; set; }
        public virtual DbSet<FeatureScope> FeatureScope { get; set; }
        public virtual DbSet<FeatureSubCategory> FeatureSubCategory { get; set; }
        public virtual DbSet<FeatureTier> FeatureTier { get; set; }
        public virtual DbSet<FeatureType> FeatureType { get; set; }
        public virtual DbSet<FileExtension> FileExtension { get; set; }
        public virtual DbSet<FileGrouping> FileGrouping { get; set; }
        public virtual DbSet<FileLink> FileLink { get; set; }
        public virtual DbSet<FileLinkHistory> FileLinkHistory { get; set; }
        public virtual DbSet<FilePermissionLevel> FilePermissionLevel { get; set; }
        public virtual DbSet<FuelType> FuelType { get; set; }
        public virtual DbSet<Garage> Garage { get; set; }
        public virtual DbSet<GarageAvailability> GarageAvailability { get; set; }
        public virtual DbSet<GarageCampaign> GarageCampaign { get; set; }
        public virtual DbSet<GarageCampaignEvent> GarageCampaignEvent { get; set; }
        public virtual DbSet<GarageCommunicationMethod> GarageCommunicationMethod { get; set; }
        public virtual DbSet<GarageContact> GarageContact { get; set; }
        public virtual DbSet<GarageDefaultAccount> GarageDefaultAccount { get; set; }
        public virtual DbSet<GarageDefaultTaxGroup> GarageDefaultTaxGroup { get; set; }
        public virtual DbSet<GarageEnquiryPartner> GarageEnquiryPartner { get; set; }
        public virtual DbSet<GarageEnquiryPartnerMenuPrice> GarageEnquiryPartnerMenuPrice { get; set; }
        public virtual DbSet<GarageEnquiryPartnerPackage> GarageEnquiryPartnerPackage { get; set; }
        public virtual DbSet<GarageHoliday> GarageHoliday { get; set; }
        public virtual DbSet<GarageIncrement> GarageIncrement { get; set; }
        public virtual DbSet<GarageItemType> GarageItemType { get; set; }
        public virtual DbSet<GarageJobStatusLevel> GarageJobStatusLevel { get; set; }
        public virtual DbSet<GarageManufacturer> GarageManufacturer { get; set; }
        public virtual DbSet<GarageMetaData> GarageMetaData { get; set; }
        public virtual DbSet<GarageMetadataType> GarageMetadataType { get; set; }
        public virtual DbSet<GarageOpeningTime> GarageOpeningTime { get; set; }
        public virtual DbSet<GarageOutOfOffice> GarageOutOfOffice { get; set; }
        public virtual DbSet<GaragePlan> GaragePlan { get; set; }
        public virtual DbSet<GaragePlanFeature> GaragePlanFeature { get; set; }
        public virtual DbSet<GarageReminderType> GarageReminderType { get; set; }
        public virtual DbSet<GarageRepairType> GarageRepairType { get; set; }
        public virtual DbSet<GarageTheme> GarageTheme { get; set; }
        public virtual DbSet<GarageType> GarageType { get; set; }
        public virtual DbSet<GarageUser> GarageUser { get; set; }
        public virtual DbSet<GarageUserMetaData> GarageUserMetaData { get; set; }
        public virtual DbSet<GarageUserPosition> GarageUserPosition { get; set; }
        public virtual DbSet<GarageVehicle> GarageVehicle { get; set; }
        public virtual DbSet<ImportFile> ImportFile { get; set; }
        public virtual DbSet<ImportFileEvent> ImportFileEvent { get; set; }
        public virtual DbSet<ImportFileStatus> ImportFileStatus { get; set; }
        public virtual DbSet<ImportFinal> ImportFinal { get; set; }
        public virtual DbSet<ImportSeed> ImportSeed { get; set; }
        public virtual DbSet<ImportStaging> ImportStaging { get; set; }
        public virtual DbSet<ImportStagingHeader> ImportStagingHeader { get; set; }
        public virtual DbSet<ImportStagingHeaderStatus> ImportStagingHeaderStatus { get; set; }
        public virtual DbSet<IncrementType> IncrementType { get; set; }
        public virtual DbSet<IntegrationType> IntegrationType { get; set; }
        public virtual DbSet<IntegrationUpdateRequest> IntegrationUpdateRequest { get; set; }
        public virtual DbSet<InternalNote> InternalNote { get; set; }
        public virtual DbSet<IntervalType> IntervalType { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobAssignee> JobAssignee { get; set; }
        public virtual DbSet<JobChat> JobChat { get; set; }
        public virtual DbSet<JobMessage> JobMessage { get; set; }
        public virtual DbSet<JobMetaData> JobMetaData { get; set; }
        public virtual DbSet<JobStatusLevel> JobStatusLevel { get; set; }
        public virtual DbSet<JobSuperStatusLevel> JobSuperStatusLevel { get; set; }
        public virtual DbSet<KeeDerivative> KeeDerivative { get; set; }
        public virtual DbSet<KeeMake> KeeMake { get; set; }
        public virtual DbSet<KeeModel> KeeModel { get; set; }
        public virtual DbSet<LoungeJob> LoungeJob { get; set; }
        public virtual DbSet<Make> Make { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Map> Map { get; set; }
        public virtual DbSet<MapReference> MapReference { get; set; }
        public virtual DbSet<MapReferenceContainer> MapReferenceContainer { get; set; }
        public virtual DbSet<MenuPriceType> MenuPriceType { get; set; }
        public virtual DbSet<MessageReminder> MessageReminder { get; set; }
        public virtual DbSet<MessageReminderInternalNote> MessageReminderInternalNote { get; set; }
        public virtual DbSet<MessageReminderJobMessage> MessageReminderJobMessage { get; set; }
        public virtual DbSet<MessageReminderRepairMessage> MessageReminderRepairMessage { get; set; }
        public virtual DbSet<MetadataCategory> MetadataCategory { get; set; }
        public virtual DbSet<MetadataType> MetadataType { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<OdometerMeasureType> OdometerMeasureType { get; set; }
        public virtual DbSet<OneTimeScriptsExecuted> OneTimeScriptsExecuted { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<PackageProduct> PackageProduct { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<PartnerType> PartnerType { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PlanTemplate> PlanTemplate { get; set; }
        public virtual DbSet<PlanTemplateFeature> PlanTemplateFeature { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<PowerType> PowerType { get; set; }
        public virtual DbSet<PreDeployOneTimeScriptsExecuted> PreDeployOneTimeScriptsExecuted { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ReferenceObjectType> ReferenceObjectType { get; set; }
        public virtual DbSet<RegistrationStatus> RegistrationStatus { get; set; }
        public virtual DbSet<ReminderCategory> ReminderCategory { get; set; }
        public virtual DbSet<ReminderType> ReminderType { get; set; }
        public virtual DbSet<Repair> Repair { get; set; }
        public virtual DbSet<RepairMessage> RepairMessage { get; set; }
        public virtual DbSet<RepairType> RepairType { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<ResourceAvailability> ResourceAvailability { get; set; }
        public virtual DbSet<ResourceAvailabilityPackage> ResourceAvailabilityPackage { get; set; }
        public virtual DbSet<ResourceRepairType> ResourceRepairType { get; set; }
        public virtual DbSet<SchemaVersions> SchemaVersions { get; set; }
        public virtual DbSet<Summary> Summary { get; set; }
        public virtual DbSet<SummaryType> SummaryType { get; set; }
        public virtual DbSet<TaxGroup> TaxGroup { get; set; }
        public virtual DbSet<TaxGroupRate> TaxGroupRate { get; set; }
        public virtual DbSet<TaxRate> TaxRate { get; set; }
        public virtual DbSet<TaxRateHistory> TaxRateHistory { get; set; }
        public virtual DbSet<TaxRateType> TaxRateType { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
        public virtual DbSet<ThemeGroup> ThemeGroup { get; set; }
        public virtual DbSet<ThemeType> ThemeType { get; set; }
        public virtual DbSet<Tier> Tier { get; set; }
        public virtual DbSet<TimeZone> TimeZone { get; set; }
        public virtual DbSet<TimelineItemStatus> TimelineItemStatus { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleClassification> VehicleClassification { get; set; }
        public virtual DbSet<VehicleClassificationRelation> VehicleClassificationRelation { get; set; }
        public virtual DbSet<VehicleContactHistory> VehicleContactHistory { get; set; }
        public virtual DbSet<VehicleLookupType> VehicleLookupType { get; set; }
        public virtual DbSet<VehicleMetadata> VehicleMetadata { get; set; }
        public virtual DbSet<VehicleMileageHistory> VehicleMileageHistory { get; set; }
        public virtual DbSet<VehicleReminder> VehicleReminder { get; set; }
        public virtual DbSet<YmmeDataOne> YmmeDataOne { get; set; }

        // Unable to generate entity type for table 'dbo.Copyright'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.importstaging_Audit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.importfinal_Audit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Culture'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.JobMessageType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MessageDeliveryMechanism'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MessageStatus'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=accarvuelocal;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasIndex(e => new { e.GarageId, e.Code })
                    .HasName("UQ_Account_Code")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.AccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_AccountTypeId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AccountCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.AccountDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Account_DeletedBy");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_GarageId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.AccountUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_UpdatedBy");
            });

            modelBuilder.Entity<AccountClass>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_AccountClass_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.AccountClassId })
                    .HasName("UQ_AccountType_Name_AccountClassId")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AccountClass)
                    .WithMany(p => p.AccountType)
                    .HasForeignKey(d => d.AccountClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountType_ClassId");
            });

            modelBuilder.Entity<AddonPackage>(entity =>
            {
                entity.HasOne(d => d.Package)
                    .WithMany(p => p.AddonPackage)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddonPackage_PackageId");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(150);

                entity.Property(e => e.Address2).HasMaxLength(150);

                entity.Property(e => e.Address3).HasMaxLength(150);

                entity.Property(e => e.Address4).HasMaxLength(150);

                entity.Property(e => e.AttentionTo).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Postcode).HasMaxLength(150);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_AddressType");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Address_CountryId");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_AddressType_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApiPartnerIntegrationModifiers>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.AzureRegion })
                    .HasName("pk_ApiPartnerIntegrationModifiers");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.ApiPartnerIntegrationModifiers)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("fk_EnquiryPartner_ApiPartnerIntegrationModifiers");
            });

            modelBuilder.Entity<AzureRegion>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_AzureRegion_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillingAccount>(entity =>
            {
                entity.Property(e => e.CompanyNumber).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TaxNumber).HasMaxLength(200);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.BillingAccount)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_BillingAccount_AddressId");

                entity.HasOne(d => d.BillingAccountStatus)
                    .WithMany(p => p.BillingAccount)
                    .HasForeignKey(d => d.BillingAccountStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingAccount_BillingAccountStatusId");

                entity.HasOne(d => d.CommunicationMethod)
                    .WithMany(p => p.BillingAccount)
                    .HasForeignKey(d => d.CommunicationMethodId)
                    .HasConstraintName("FK_BillingAccount_CommunicationMethodId");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.BillingAccount)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingAccount_PartnerId");
            });

            modelBuilder.Entity<BillingAccountInvoicee>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BillingAccount)
                    .WithMany(p => p.BillingAccountInvoicee)
                    .HasForeignKey(d => d.BillingAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingAccountInvoicee_BillingAccountId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BillingAccountInvoiceeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingAccountInvoicee_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.BillingAccountInvoiceeDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_BillingAccountInvoicee_DeletedBy");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.BillingAccountInvoiceeUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingAccountInvoicee_UpdatedBy");
            });

            modelBuilder.Entity<BillingAccountStatus>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_BillingAccountStatus_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CampaignType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<CommunicationMethod>(entity =>
            {
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CommunicationMethodType)
                    .WithMany(p => p.CommunicationMethod)
                    .HasForeignKey(d => d.CommunicationMethodTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommunicationMethod_CommunicationMethodType");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.CommunicationMethod)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_CommunicationMethod_DeletedBy");
            });

            modelBuilder.Entity<CommunicationMethodType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_CommunicationMethodType_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommunicationType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("UQ_CommunicationType_Id")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("UQ_CommunicationType_Name")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.CContactTypes).HasColumnName("c_ContactTypes");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ContactCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ContactDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Contact_DeletedBy");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_Contact_MapReferenceContainer");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ContactUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_UpdatedBy");
            });

            modelBuilder.Entity<ContactAddress>(entity =>
            {
                entity.HasIndex(e => new { e.ContactId, e.AddressTypeId })
                    .HasName("UQ_ContactAddress_ContactId_AddressTypeId")
                    .IsUnique();

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.ContactAddress)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_ContactAddress_MapReferenceContainer");
            });

            modelBuilder.Entity<ContactCommunicationMethod>(entity =>
            {
                entity.HasIndex(e => e.CommunicationMethodId);

                entity.HasIndex(e => e.ContactId);

                entity.HasOne(d => d.CommunicationMethodType)
                    .WithMany(p => p.ContactCommunicationMethod)
                    .HasForeignKey(d => d.CommunicationMethodTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactCommunicationMethod_CommunicationMethodType");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactCommunicationMethod)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactCommunicationMethod_Contact");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.ContactCommunicationMethod)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_ContactCommunicationMethod_MapReferenceContainer");
            });

            modelBuilder.Entity<ContactContactType>(entity =>
            {
                entity.HasKey(e => new { e.ContactId, e.ContactTypeId })
                    .HasName("PK_ContactContactType_ContactId_ContactTypeId");

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.ContactTypeId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactContactType)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactContactType_ContactId");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.ContactContactType)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactContactType_ContactTypeId");
            });

            modelBuilder.Entity<ContactMetadata>(entity =>
            {
                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactMetadata)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactMetadata_Contact");

                entity.HasOne(d => d.MetadataType)
                    .WithMany(p => p.ContactMetadata)
                    .HasForeignKey(d => d.MetadataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactMetadata_MetadataType");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_ContactType_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DialCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.AzureRegion)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.AzureRegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_AzureRegionId");
            });

            modelBuilder.Entity<CountryDefaults>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("UQ_CountryDefaults_CountryId")
                    .IsUnique();

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithOne(p => p.CountryDefaults)
                    .HasForeignKey<CountryDefaults>(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryDefaults_CountryId");

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.CountryDefaults)
                    .HasForeignKey(d => d.CurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryDefaults_CurrencyCode");

                entity.HasOne(d => d.TimeZone)
                    .WithMany(p => p.CountryDefaults)
                    .HasForeignKey(d => d.TimeZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryDefaults_TimeZoneId");
            });

            modelBuilder.Entity<CountryTaxRateTemplate>(entity =>
            {
                entity.HasIndex(e => new { e.CountryId, e.TaxGroupCode, e.TaxRateCode })
                    .HasName("UQ_CountryTaxRateTemplate_CountryId_TaxGroupCode_TaxRateCode")
                    .IsUnique();

                entity.Property(e => e.TaxGroupCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TaxGroupDescription).HasMaxLength(30);

                entity.Property(e => e.TaxRateCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TaxRateName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaxRateValue).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryTaxRateTemplate)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryTaxRateTemplate_CountryId");

                entity.HasOne(d => d.TaxRateType)
                    .WithMany(p => p.CountryTaxRateTemplate)
                    .HasForeignKey(d => d.TaxRateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryTaxRateTemplate_TaxRateTypeId");
            });

            modelBuilder.Entity<CurrencyCode>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode1);

                entity.Property(e => e.CurrencyCode1)
                    .HasColumnName("CurrencyCode")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Isocode).HasColumnName("ISOCode");
            });

            modelBuilder.Entity<CustomerLoungeImportHistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateStarted).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerLoungeImportHistoryLog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateLogged)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message).IsRequired();

                entity.HasOne(d => d.CustomerLoungeImportHistory)
                    .WithMany(p => p.CustomerLoungeImportHistoryLog)
                    .HasForeignKey(d => d.CustomerLoungeImportHistoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerLoungeImportHistoryLog_CustomerLoungeImportHistory");
            });

            modelBuilder.Entity<DataOneDerivative>(entity =>
            {
                entity.ToTable("DataOneDerivative", "VehicleLookup");

                entity.HasIndex(e => new { e.ModelId, e.Name })
                    .HasName("IX_DataOneDerivative_ModelIdName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.DataOneDerivative)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataOneDerivative_Model");
            });

            modelBuilder.Entity<DataOneMake>(entity =>
            {
                entity.ToTable("DataOneMake", "VehicleLookup");

                entity.HasIndex(e => e.Name);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Year)
                    .WithMany(p => p.DataOneMake)
                    .HasForeignKey(d => d.YearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataOneMake_Year");
            });

            modelBuilder.Entity<DataOneModel>(entity =>
            {
                entity.ToTable("DataOneModel", "VehicleLookup");

                entity.HasIndex(e => new { e.MakeId, e.Name })
                    .HasName("IX_DataOneModel_MakeIdName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Make)
                    .WithMany(p => p.DataOneModel)
                    .HasForeignKey(d => d.MakeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataOneModel_Make");
            });

            modelBuilder.Entity<DataOneYear>(entity =>
            {
                entity.ToTable("DataOneYear", "VehicleLookup");

                entity.HasIndex(e => e.Name);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DaysSinceMinDate>(entity =>
            {
                entity.Property(e => e.ActualDate).HasColumnType("datetime");

                entity.Property(e => e.DayName)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Default>(entity =>
            {
                entity.HasIndex(e => new { e.DefaultTypeId, e.Name })
                    .HasName("UQ_Default_DefaultTypeId_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AccountClass)
                    .WithMany(p => p.Default)
                    .HasForeignKey(d => d.AccountClassId)
                    .HasConstraintName("FK_Default_AccountClassId");

                entity.HasOne(d => d.DefaultType)
                    .WithMany(p => p.InverseDefaultType)
                    .HasForeignKey(d => d.DefaultTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Default_DefaultTypeId");
            });

            modelBuilder.Entity<DefaultType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_DefaultType_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Derivative>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Derivative)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_Derivative_Model");
            });

            modelBuilder.Entity<DevicePlatform>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DropOffTime>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DropOffTimeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DropOffTime_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DropOffTimeDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_DropOffTime_DeletedBy");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.DropOffTime)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DropOffTime_GarageId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.DropOffTimeUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DropOffTime_UpdatedBy");
            });

            modelBuilder.Entity<DropOffTimeDayOfWeek>(entity =>
            {
                entity.HasOne(d => d.DropOffTime)
                    .WithMany(p => p.DropOffTimeDayOfWeek)
                    .HasForeignKey(d => d.DropOffTimeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DropOffTimeDayOfWeek_DropOffTimeId");
            });

            modelBuilder.Entity<Enquiry>(entity =>
            {
                entity.HasIndex(e => e.AcceptedBy);

                entity.HasIndex(e => e.EnquiryRef);

                entity.HasIndex(e => e.GarageId);

                entity.HasIndex(e => e.JobId);

                entity.HasIndex(e => new { e.EnquiryPartnerId, e.GarageId })
                    .HasName("IX_Enquiry_EnquiryPartner_Garage");

                entity.Property(e => e.AcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.ContactEmail).HasMaxLength(255);

                entity.Property(e => e.ContactFirstName).HasMaxLength(50);

                entity.Property(e => e.ContactLastName).HasMaxLength(50);

                entity.Property(e => e.ContactMobile).HasMaxLength(255);

                entity.Property(e => e.ContactTel).HasMaxLength(255);

                entity.Property(e => e.ContactTitle).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeclinedDate).HasColumnType("datetime");

                entity.Property(e => e.EnquiryPreferredBookingDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProposedEnd).HasColumnType("datetime");

                entity.Property(e => e.ProposedStart).HasColumnType("datetime");

                entity.Property(e => e.VehicleDerivative).HasMaxLength(100);

                entity.Property(e => e.VehicleMake).HasMaxLength(100);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleRegNo).HasMaxLength(50);

                entity.Property(e => e.VehicleVin).HasMaxLength(200);

                entity.HasOne(d => d.AcceptedByNavigation)
                    .WithMany(p => p.EnquiryAcceptedByNavigation)
                    .HasForeignKey(d => d.AcceptedBy)
                    .HasConstraintName("FK_Enquiry_AcceptedBy");

                entity.HasOne(d => d.DeclinedByNavigation)
                    .WithMany(p => p.EnquiryDeclinedByNavigation)
                    .HasForeignKey(d => d.DeclinedBy)
                    .HasConstraintName("FK_Enquiry_DeclinedBy");

                entity.HasOne(d => d.EnquiryPartner)
                    .WithMany(p => p.Enquiry)
                    .HasForeignKey(d => d.EnquiryPartnerId)
                    .HasConstraintName("FK_Enquiry_EnquiryPartnerId");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Enquiry)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Enquiry_GarageId");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Enquiry)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_Enquiry_JobId");
            });

            modelBuilder.Entity<EnquiryMessage>(entity =>
            {
                entity.Property(e => e.ContactAddress).IsRequired();

                entity.Property(e => e.Content).HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MetaData).HasMaxLength(255);

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.Property(e => e.StatusMessage)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EnquiryMessage)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryMessage_CreatedBy");

                entity.HasOne(d => d.Enquiry)
                    .WithMany(p => p.EnquiryMessage)
                    .HasForeignKey(d => d.EnquiryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryMessage_EnquiryId");
            });

            modelBuilder.Entity<EnquiryMetaData>(entity =>
            {
                entity.HasKey(e => new { e.Name, e.EnquiryId });

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.Enquiry)
                    .WithMany(p => p.EnquiryMetaData)
                    .HasForeignKey(d => d.EnquiryId)
                    .HasConstraintName("FK_EnquiryMetaData_EnquiryId");
            });

            modelBuilder.Entity<EnquiryPackageInfo>(entity =>
            {
                entity.Property(e => e.Details).HasMaxLength(1000);

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.Enquiry)
                    .WithMany(p => p.EnquiryPackageInfo)
                    .HasForeignKey(d => d.EnquiryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPackageInfo_EnquiryId");

                entity.HasOne(d => d.EnquiryPartnerPackage)
                    .WithMany(p => p.EnquiryPackageInfo)
                    .HasForeignKey(d => d.EnquiryPartnerPackageId)
                    .HasConstraintName("FK_EnquiryPackageInfo_EnquiryPartnerPackageId");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.EnquiryPackageInfo)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPackageInfo_PackageId");

                entity.HasOne(d => d.VehicleClassification)
                    .WithMany(p => p.EnquiryPackageInfo)
                    .HasForeignKey(d => d.VehicleClassificationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_EnquiryPackageInfo_VehicleClassification");
            });

            modelBuilder.Entity<EnquiryPartner>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<EnquiryPartnerGarageContact>(entity =>
            {
                entity.HasIndex(e => new { e.EnquiryPartnerId, e.GarageId, e.ContactId })
                    .HasName("UQ_EnquiryPartnerGarageContact_EnquiryPartnerId_GarageId_ContactId")
                    .IsUnique();
            });

            modelBuilder.Entity<EnquiryPartnerGarageUser>(entity =>
            {
                entity.HasIndex(e => e.GarageUserRef)
                    .HasName("UQ_EnquiryPartnerGarageUser_GarageUserRef")
                    .IsUnique();

                entity.HasIndex(e => new { e.EnquiryPartnerId, e.GarageId, e.GarageUserId })
                    .HasName("UQ_EnquiryPartnerGarageUser_EnquiryPartnerId_GarageId_GarageUserId")
                    .IsUnique();

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.EnquiryPartnerGarageUser)
                    .HasForeignKey(d => d.GarageId)
                    .HasConstraintName("fk_EnquiryPartnerGarageUser_Gargage");

                entity.HasOne(d => d.GarageUser)
                    .WithMany(p => p.EnquiryPartnerGarageUser)
                    .HasForeignKey(d => d.GarageUserId)
                    .HasConstraintName("fk_EnquiryPartnerGarageUser_GargageUser");
            });

            modelBuilder.Entity<EnquiryPartnerGarageVehicle>(entity =>
            {
                entity.HasIndex(e => new { e.EnquiryPartnerId, e.GarageId, e.VehicleId })
                    .HasName("UQ_EnquiryPartnerGarageVehicle_EnquiryPartnerId_GarageId_VehicleId")
                    .IsUnique();

                entity.HasOne(d => d.EnquiryPartner)
                    .WithMany(p => p.EnquiryPartnerGarageVehicle)
                    .HasForeignKey(d => d.EnquiryPartnerId)
                    .HasConstraintName("fk_EnquiryPartnerGarageVehicle_EnquiryPartner");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.EnquiryPartnerGarageVehicle)
                    .HasForeignKey(d => d.GarageId)
                    .HasConstraintName("fk_EnquiryPartnerGarageVehicle_Garage");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.EnquiryPartnerGarageVehicle)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("fk_EnquiryPartnerGarageVehicle_Vehicle");
            });

            modelBuilder.Entity<EnquiryPartnerMenuPrice>(entity =>
            {
                entity.HasIndex(e => new { e.EnquiryPartnerPackageId, e.CurrencyCode, e.VehicleClassificationId, e.MenuPriceTypeId })
                    .HasName("UC_EnquiryPartnerPackageId_CurrencyCode_VehicleClassificationId_MenuPriceTypeId")
                    .IsUnique();

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.EnquiryPartnerPackage)
                    .WithMany(p => p.EnquiryPartnerMenuPrice)
                    .HasForeignKey(d => d.EnquiryPartnerPackageId)
                    .HasConstraintName("fk_EnquiryPartnerMenuPrice_EnquiryPartnerPackage");

                entity.HasOne(d => d.VehicleClassification)
                    .WithMany(p => p.EnquiryPartnerMenuPrice)
                    .HasForeignKey(d => d.VehicleClassificationId)
                    .HasConstraintName("fk_EnquiryPartnerMenuPrice_VehicleClassification");
            });

            modelBuilder.Entity<EnquiryPartnerMetaData>(entity =>
            {
                entity.HasIndex(e => e.EnquiryPartnerId);

                entity.HasIndex(e => e.MetadataTypeId);

                entity.HasOne(d => d.EnquiryPartner)
                    .WithMany(p => p.EnquiryPartnerMetaData)
                    .HasForeignKey(d => d.EnquiryPartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPartnerMetaData_EnquiryPartnerId");

                entity.HasOne(d => d.MetadataType)
                    .WithMany(p => p.EnquiryPartnerMetaData)
                    .HasForeignKey(d => d.MetadataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPartnerMetaData_MetadataTypeId");
            });

            modelBuilder.Entity<EnquiryPartnerPackage>(entity =>
            {
                entity.HasIndex(e => e.DeletedBy);

                entity.HasIndex(e => e.EnquiryPartnerId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(800);

                entity.Property(e => e.Duration).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.RepairTypeId).HasDefaultValueSql("((11))");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.EnquiryPartnerPackage)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_EnquiryPartnerPackage_DeletedBy");

                entity.HasOne(d => d.EnquiryPartner)
                    .WithMany(p => p.EnquiryPartnerPackage)
                    .HasForeignKey(d => d.EnquiryPartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPartnerPackage_EnquiryPartnerId");

                entity.HasOne(d => d.RepairType)
                    .WithMany(p => p.EnquiryPartnerPackage)
                    .HasForeignKey(d => d.RepairTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPartnerPackage_RepairTypeId");
            });

            modelBuilder.Entity<EnquiryPartnerPackageMapping>(entity =>
            {
                entity.HasKey(e => e.PackageRef)
                    .HasName("PK_EnquiryPartnerPackageMapping_Id");

                entity.HasIndex(e => new { e.EnquiryPartnerId, e.GarageId, e.PackageId })
                    .HasName("UQ_EnquiryPartnerPackageMapping_EnquiryPartnerId_GarageId_PackageId")
                    .IsUnique();

                entity.Property(e => e.PackageRef).ValueGeneratedNever();
            });

            modelBuilder.Entity<EnquiryPartnerTheme>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EnquiryPartnerThemeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPartnerTheme_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.EnquiryPartnerThemeDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_EnquiryPartnerTheme_DeletedBy");

                entity.HasOne(d => d.EnquiryPartner)
                    .WithMany(p => p.EnquiryPartnerTheme)
                    .HasForeignKey(d => d.EnquiryPartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPartnerTheme_EnquiryPartner");

                entity.HasOne(d => d.ThemeGroup)
                    .WithMany(p => p.EnquiryPartnerTheme)
                    .HasForeignKey(d => d.ThemeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPartnerTheme_ThemeGroup");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.EnquiryPartnerTheme)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPartnerTheme_Theme");

                entity.HasOne(d => d.ThemeType)
                    .WithMany(p => p.EnquiryPartnerTheme)
                    .HasForeignKey(d => d.ThemeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPartnerTheme_ThemeType");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.EnquiryPartnerThemeUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryPartnerTheme_UpdatedBy");
            });

            modelBuilder.Entity<Facilities>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_Facilities_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Modules).HasDefaultValueSql("((3))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Feature_CountryId");

                entity.HasOne(d => d.FeatureCategory)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.FeatureCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feature_FeatureCategoryId");

                entity.HasOne(d => d.FeatureSubCategory)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.FeatureSubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feature_FeatureSubCategoryId");

                entity.HasOne(d => d.FeatureType)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.FeatureTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feature_FeatureTypeId");

                entity.HasOne(d => d.Scope)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.ScopeId)
                    .HasConstraintName("FK_Feature_ScopeId");
            });

            modelBuilder.Entity<FeatureCategory>(entity =>
            {
                entity.HasIndex(e => e.CategoryValue)
                    .HasName("UQ_FeatureCategory_CategoryValue")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CategoryValue)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeatureConfig>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeatureScope>(entity =>
            {
                entity.HasIndex(e => e.ScopeValue)
                    .HasName("UQ_FeatureScope_ScopeValue")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ScopeValue)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeatureSubCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_FeatureSubCategory_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.FeatureCategory)
                    .WithMany(p => p.FeatureSubCategory)
                    .HasForeignKey(d => d.FeatureCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeatureSubCategory_FeatureCategory");
            });

            modelBuilder.Entity<FeatureTier>(entity =>
            {
                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.FeatureTier)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeatureTier_FeatureId");

                entity.HasOne(d => d.Tier)
                    .WithMany(p => p.FeatureTier)
                    .HasForeignKey(d => d.TierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeatureTier_TierId");
            });

            modelBuilder.Entity<FeatureType>(entity =>
            {
                entity.HasIndex(e => e.TypeValue)
                    .HasName("UQ_FeatureType_TypeValue")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TypeValue)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FileExtension>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<FileGrouping>(entity =>
            {
                entity.HasOne(d => d.ReferenceObjectType)
                    .WithMany(p => p.FileGrouping)
                    .HasForeignKey(d => d.ReferenceObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FileGrouping_ReferenceObjectTypeId");
            });

            modelBuilder.Entity<FileLink>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FileGrouping)
                    .WithMany(p => p.FileLink)
                    .HasForeignKey(d => d.FileGroupingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FileLink_FileGroupingId");

                entity.HasOne(d => d.FilePermissionLevel)
                    .WithMany(p => p.FileLink)
                    .HasForeignKey(d => d.FilePermissionLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FileLink_FilePermissionLevelId");
            });

            modelBuilder.Entity<FileLinkHistory>(entity =>
            {
                entity.Property(e => e.BlobName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerReadDate).HasColumnType("datetime");

                entity.HasOne(d => d.FileExtension)
                    .WithMany(p => p.FileLinkHistory)
                    .HasForeignKey(d => d.FileExtensionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FileLinkHistory_FileExtensionId");

                entity.HasOne(d => d.FileLink)
                    .WithMany(p => p.FileLinkHistory)
                    .HasForeignKey(d => d.FileLinkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FileLinkHistory_FileLinkId");
            });

            modelBuilder.Entity<FilePermissionLevel>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FuelType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_FuelType_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Garage>(entity =>
            {
                entity.HasIndex(e => e.Name);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DoCdkimport).HasColumnName("DoCDKImport");

                entity.Property(e => e.Latitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.LogoUrl).HasMaxLength(300);

                entity.Property(e => e.Longitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Modules).HasDefaultValueSql("((3))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.OpeningTimes).HasMaxLength(300);

                entity.Property(e => e.RegistrationStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.SimplifiedJobForm)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TimeZoneId).HasDefaultValueSql("((41))");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Garage)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Garage_AddressId");

                entity.HasOne(d => d.BillingAccount)
                    .WithMany(p => p.Garage)
                    .HasForeignKey(d => d.BillingAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Garage_BillingAccountId");

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Garage)
                    .HasForeignKey(d => d.CurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Garage_CurrencyCode");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.GarageDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Garage_DeletedBy");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.Garage)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_Garage_MapReferenceContainer");

                entity.HasOne(d => d.OdometerMeasureType)
                    .WithMany(p => p.Garage)
                    .HasForeignKey(d => d.OdometerMeasureTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Garage_OdometerMeasureTypeId");

                entity.HasOne(d => d.RegistrationStatus)
                    .WithMany(p => p.Garage)
                    .HasForeignKey(d => d.RegistrationStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Garage_RegistrationStatusId");

                entity.HasOne(d => d.TimeZone)
                    .WithMany(p => p.Garage)
                    .HasForeignKey(d => d.TimeZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Garage_TimeZoneId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.GarageUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Garage_UpdatedBy");
            });

            modelBuilder.Entity<GarageAvailability>(entity =>
            {
                entity.HasIndex(e => e.GarageId);

                entity.HasIndex(e => new { e.GarageId, e.DayOfWeek })
                    .HasName("UQ_GarageAvailability_GarageId_Day_of_Week")
                    .IsUnique();

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageAvailability)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageAvailability_GarageId");
            });

            modelBuilder.Entity<GarageCampaign>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Message).HasMaxLength(800);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CampaignType)
                    .WithMany(p => p.GarageCampaign)
                    .HasForeignKey(d => d.CampaignTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageCampaign_CanpaignTypeId");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageCampaign)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageCampaign_GarageId");

                entity.HasOne(d => d.IntervalType)
                    .WithMany(p => p.GarageCampaign)
                    .HasForeignKey(d => d.IntervalTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageCampaign_IntervalTypeId");
            });

            modelBuilder.Entity<GarageCampaignEvent>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.GarageCampaign)
                    .WithMany(p => p.GarageCampaignEvent)
                    .HasForeignKey(d => d.GarageCampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageCampaignEvents_GarageCanpaignId");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageCampaignEvent)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageCampaignEvents_GarageId");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.GarageCampaignEvent)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageCampaignEvents_JobId");
            });

            modelBuilder.Entity<GarageCommunicationMethod>(entity =>
            {
                entity.HasOne(d => d.CommunicationMethodType)
                    .WithMany(p => p.GarageCommunicationMethod)
                    .HasForeignKey(d => d.CommunicationMethodTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageCommunicationMethod_CommunicationMethodType");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageCommunicationMethod)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageCommunicationMethod_Contact");
            });

            modelBuilder.Entity<GarageContact>(entity =>
            {
                entity.HasKey(e => new { e.GarageId, e.ContactId });

                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.GarageId);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.GarageContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageContact_ContactId");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageContact)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageContact_GarageId");
            });

            modelBuilder.Entity<GarageDefaultAccount>(entity =>
            {
                entity.HasOne(d => d.Account)
                    .WithMany(p => p.GarageDefaultAccount)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageDefaultAccount_AccountId");

                entity.HasOne(d => d.Default)
                    .WithMany(p => p.GarageDefaultAccount)
                    .HasForeignKey(d => d.DefaultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageDefaultAccount_DefaultId");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageDefaultAccount)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageDefaultAccount_GarageId");
            });

            modelBuilder.Entity<GarageDefaultTaxGroup>(entity =>
            {
                entity.HasIndex(e => new { e.GarageId, e.DefaultId })
                    .HasName("CK_GarageDefaultTaxGroup_GarageId_DefaultId")
                    .IsUnique();

                entity.HasOne(d => d.Default)
                    .WithMany(p => p.GarageDefaultTaxGroup)
                    .HasForeignKey(d => d.DefaultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageDefaultTaxGroup_DefaultId");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageDefaultTaxGroup)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageDefaultTaxGroup_GarageId");

                entity.HasOne(d => d.TaxGroup)
                    .WithMany(p => p.GarageDefaultTaxGroup)
                    .HasForeignKey(d => d.TaxGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageDefaultTaxGroup_TaxGroupId");
            });

            modelBuilder.Entity<GarageEnquiryPartner>(entity =>
            {
                entity.HasIndex(e => e.GarageId);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.IsPending)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.GarageEnquiryPartnerCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageEnquiryPartner_CreatedBy");

                entity.HasOne(d => d.EnquiryPartner)
                    .WithMany(p => p.GarageEnquiryPartner)
                    .HasForeignKey(d => d.EnquiryPartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageEnquiryPartner_EnquiryPartnerId");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageEnquiryPartner)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageEnquiryPartner_GarageId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.GarageEnquiryPartnerModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_GarageEnquiryPartner_ModifiedBy");
            });

            modelBuilder.Entity<GarageEnquiryPartnerMenuPrice>(entity =>
            {
                entity.HasIndex(e => new { e.GarageEnquiryPartnerPackageId, e.CurrencyCode, e.VehicleClassificationId, e.MenuPriceTypeId })
                    .HasName("UC_GarageEnquiryPartnerPackageId_CurrencyCode_VehicleClassificationId_MenuPriceTypeId")
                    .IsUnique();

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.GarageEnquiryPartnerPackage)
                    .WithMany(p => p.GarageEnquiryPartnerMenuPrice)
                    .HasForeignKey(d => d.GarageEnquiryPartnerPackageId)
                    .HasConstraintName("fk_GarageEnquiryPartnerMenuPrice_GarageEnquiryPartnerPackage");

                entity.HasOne(d => d.MenuPriceType)
                    .WithMany(p => p.GarageEnquiryPartnerMenuPrice)
                    .HasForeignKey(d => d.MenuPriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_GarageEnquiryPartnerMenuPrice_MenuPriceTypeId");

                entity.HasOne(d => d.VehicleClassification)
                    .WithMany(p => p.GarageEnquiryPartnerMenuPrice)
                    .HasForeignKey(d => d.VehicleClassificationId)
                    .HasConstraintName("fk_GarageEnquiryPartnerMenuPrice_VehicleClassification");
            });

            modelBuilder.Entity<GarageEnquiryPartnerPackage>(entity =>
            {
                entity.HasIndex(e => e.EnquiryPartnerPackageId);

                entity.HasIndex(e => e.GarageId);

                entity.HasIndex(e => e.PackageId);

                entity.HasIndex(e => new { e.GarageId, e.EnquiryPartnerPackageId })
                    .HasName("UQ_GarageEnquiryPartnerPackage_GarageId_EnquiryPartnerPackageId")
                    .IsUnique();

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.Value).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.GarageEnquiryPartnerPackage)
                    .HasForeignKey(d => d.CurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageEnquiryPartnerPackage_CurrencyCode");

                entity.HasOne(d => d.EnquiryPartnerPackage)
                    .WithMany(p => p.GarageEnquiryPartnerPackage)
                    .HasForeignKey(d => d.EnquiryPartnerPackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageEnquiryPartnerPackage_EnquiryPartnerPackageId");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageEnquiryPartnerPackage)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageEnquiryPartnerPackage_GarageId");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.GarageEnquiryPartnerPackage)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageEnquiryPartnerPackage_PackageId");
            });

            modelBuilder.Entity<GarageHoliday>(entity =>
            {
                entity.HasIndex(e => e.GarageId);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageHoliday)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageHoliday_GarageId");
            });

            modelBuilder.Entity<GarageIncrement>(entity =>
            {
                entity.HasIndex(e => new { e.GarageId, e.IncrementTypeId })
                    .HasName("UQ_GarageIncrement_Column")
                    .IsUnique();

                entity.Property(e => e.StartPrefix)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageIncrement)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageIncrement_Garage");

                entity.HasOne(d => d.IncrementType)
                    .WithMany(p => p.GarageIncrement)
                    .HasForeignKey(d => d.IncrementTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageIncrement_IncrementType");
            });

            modelBuilder.Entity<GarageItemType>(entity =>
            {
                entity.HasIndex(e => e.DeletedBy);

                entity.HasIndex(e => e.GarageId);

                entity.HasIndex(e => e.ItemTypeId);

                entity.HasIndex(e => new { e.GarageId, e.ItemTypeId, e.Name })
                    .HasName("UQ_GarageItemType_GarageId_ItemTypeId_Name")
                    .IsUnique();

                entity.HasIndex(e => new { e.GarageId, e.ItemTypeId, e.OrderBy })
                    .HasName("UQ_GarageItemType_GarageId_ItemTypeId_OrderBy")
                    .IsUnique();

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.GarageItemType)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_GarageItemType_DeletedBy");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageItemType)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageItemType_GarageId");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.GarageItemType)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageItemType_ItemTypeId");
            });

            modelBuilder.Entity<GarageJobStatusLevel>(entity =>
            {
                entity.HasIndex(e => e.ReplicationId)
                    .HasName("UQ_GarageJobStatusLevel_ReplicationId");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageJobStatusLevel)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageJobStatusLevel_GarageId");

                entity.HasOne(d => d.JobStatusLevel)
                    .WithMany(p => p.GarageJobStatusLevel)
                    .HasForeignKey(d => d.JobStatusLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageJobStatusLevel_JobStatusLevelId");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.GarageJobStatusLevel)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_GarageJobStatusLevel_MapReferenceContainer");
            });

            modelBuilder.Entity<GarageManufacturer>(entity =>
            {
                entity.HasIndex(e => e.GarageId);

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageManufacturer)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageManufacturer_GarageId");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.GarageManufacturer)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageManufacturer_ManufacturerId");
            });

            modelBuilder.Entity<GarageMetaData>(entity =>
            {
                entity.HasIndex(e => e.GarageId)
                    .HasName("IX_GarageMetaData_JobId");

                entity.HasIndex(e => e.MetadataTypeId);

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageMetaData)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageMetaData_JobId");

                entity.HasOne(d => d.MetadataType)
                    .WithMany(p => p.GarageMetaData)
                    .HasForeignKey(d => d.MetadataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageMetaData_MetadataTypeId");
            });

            modelBuilder.Entity<GarageMetadataType>(entity =>
            {
                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageMetadataType)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageMetadataType_Garage");

                entity.HasOne(d => d.MetadataType)
                    .WithMany(p => p.GarageMetadataType)
                    .HasForeignKey(d => d.MetadataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageMetadataType_MetadataType");
            });

            modelBuilder.Entity<GarageOpeningTime>(entity =>
            {
                entity.HasIndex(e => e.GarageId);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TimeFrom).HasColumnType("datetime");

                entity.Property(e => e.TimeTo).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.GarageOpeningTime)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageOpeningTime_CreatedBy");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageOpeningTime)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageOpeningTime_GarageId");
            });

            modelBuilder.Entity<GarageOutOfOffice>(entity =>
            {
                entity.HasKey(e => e.GarageId);

                entity.Property(e => e.GarageId).ValueGeneratedNever();

                entity.Property(e => e.Smstext)
                    .HasColumnName("SMSText")
                    .HasMaxLength(1024);

                entity.HasOne(d => d.Garage)
                    .WithOne(p => p.GarageOutOfOffice)
                    .HasForeignKey<GarageOutOfOffice>(d => d.GarageId)
                    .HasConstraintName("FK_GarageOutOfOffice_Garage");
            });

            modelBuilder.Entity<GaragePlan>(entity =>
            {
                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GaragePlan)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GaragePlan_GarageId");

                entity.HasOne(d => d.PlanTemplate)
                    .WithMany(p => p.GaragePlan)
                    .HasForeignKey(d => d.PlanTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GaragePlan_PlanTemplate");
            });

            modelBuilder.Entity<GaragePlanFeature>(entity =>
            {
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.GaragePlanFeature)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GaragePlanFeature_FeatureId");

                entity.HasOne(d => d.GaragePlan)
                    .WithMany(p => p.GaragePlanFeature)
                    .HasForeignKey(d => d.GaragePlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GaragePlanFeature_GaragePlanId");
            });

            modelBuilder.Entity<GarageReminderType>(entity =>
            {
                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageReminderType)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageReminderType_Garage");

                entity.HasOne(d => d.ReminderType)
                    .WithMany(p => p.GarageReminderType)
                    .HasForeignKey(d => d.ReminderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageReminderType_ReminderType");
            });

            modelBuilder.Entity<GarageRepairType>(entity =>
            {
                entity.HasIndex(e => e.DeletedBy);

                entity.HasIndex(e => e.GarageId);

                entity.HasIndex(e => e.RepairTypeId);

                entity.HasIndex(e => new { e.GarageId, e.RepairTypeId, e.Name })
                    .HasName("UQ_GarageRepairType_GarageId_RepairTypeId_Name")
                    .IsUnique();

                entity.HasIndex(e => new { e.GarageId, e.RepairTypeId, e.OrderBy })
                    .HasName("UQ_GarageRepairType_GarageId_RepairTypeId_OrderBy")
                    .IsUnique();

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.GarageRepairType)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_GarageRepairType_DeletedBy");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageRepairType)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageRepairType_GarageId");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.GarageRepairType)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_GarageRepairType_MapReferenceContainer");

                entity.HasOne(d => d.RepairType)
                    .WithMany(p => p.GarageRepairType)
                    .HasForeignKey(d => d.RepairTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageRepairType_RepairTypeId");
            });

            modelBuilder.Entity<GarageTheme>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.GarageThemeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageTheme_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.GarageThemeDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_GarageTheme_DeletedBy");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageTheme)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageTheme_Garage");

                entity.HasOne(d => d.ThemeGroup)
                    .WithMany(p => p.GarageTheme)
                    .HasForeignKey(d => d.ThemeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageTheme_ThemeGroup");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.GarageTheme)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageTheme_Theme");

                entity.HasOne(d => d.ThemeType)
                    .WithMany(p => p.GarageTheme)
                    .HasForeignKey(d => d.ThemeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageTheme_ThemeType");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.GarageThemeUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageTheme_UpdatedBy");
            });

            modelBuilder.Entity<GarageType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_GarageType_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GarageUser>(entity =>
            {
                entity.Property(e => e.CPositions).HasColumnName("c_Positions");

                entity.Property(e => e.CdkuserName)
                    .HasColumnName("CDKUserName")
                    .HasMaxLength(100);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.InvitedDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageUser)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageUser_Garage");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.GarageUser)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageUser_Permission");
            });

            modelBuilder.Entity<GarageUserMetaData>(entity =>
            {
                entity.HasOne(d => d.GarageUser)
                    .WithMany(p => p.GarageUserMetaData)
                    .HasForeignKey(d => d.GarageUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageUserMetaData_GarageUser");

                entity.HasOne(d => d.MetadataType)
                    .WithMany(p => p.GarageUserMetaData)
                    .HasForeignKey(d => d.MetadataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageUserMetaData_MetadataType");
            });

            modelBuilder.Entity<GarageUserPosition>(entity =>
            {
                entity.HasKey(e => new { e.GarageUserId, e.PositionId });

                entity.HasIndex(e => e.GarageUserId);

                entity.HasIndex(e => e.PositionId);

                entity.HasOne(d => d.GarageUser)
                    .WithMany(p => p.GarageUserPosition)
                    .HasForeignKey(d => d.GarageUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageUserPosition_GarageUser");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.GarageUserPosition)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageUserPosition_PositionId");
            });

            modelBuilder.Entity<GarageVehicle>(entity =>
            {
                entity.HasKey(e => new { e.GarageId, e.VehicleId });

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.GarageVehicle)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageVehicle_GarageId");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.GarageVehicle)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarageVehicle_VehicleId");
            });

            modelBuilder.Entity<ImportFile>(entity =>
            {
                entity.HasIndex(e => new { e.GarageId, e.FileName })
                    .IsUnique();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('Unprocessed')");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.ImportFile)
                    .HasForeignKey(d => d.GarageId)
                    .HasConstraintName("fk_ImportFile_Garage");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.ImportFile)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ImportFile_ImportFileStatus");
            });

            modelBuilder.Entity<ImportFileEvent>(entity =>
            {
                entity.Property(e => e.EventDetail).IsRequired();

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ImportFileEvent)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("fk_ImportFileEvent_ImportFile");
            });

            modelBuilder.Entity<ImportFileStatus>(entity =>
            {
                entity.HasKey(e => e.Status)
                    .HasName("pk_ImportFileStatus");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(32)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ImportFinal>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(1000);

                entity.Property(e => e.Address3).HasMaxLength(100);

                entity.Property(e => e.Address4).HasMaxLength(100);

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.Derivative).HasMaxLength(255);

                entity.Property(e => e.Dmsadvisor)
                    .HasColumnName("DMSAdvisor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DmsadvisorId).HasColumnName("DMSAdvisorId");

                entity.Property(e => e.DmscustomerId).HasColumnName("DMSCustomerId");

                entity.Property(e => e.Dmsid).HasColumnName("DMSId");

                entity.Property(e => e.DmsrepairId).HasColumnName("DMSRepairId");

                entity.Property(e => e.DmsvehicleId).HasColumnName("DMSVehicleId");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.JobImportFailedReason).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Make).HasMaxLength(255);

                entity.Property(e => e.Mobile).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.Postcode).HasMaxLength(20);

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Reg).HasMaxLength(255);

                entity.Property(e => e.RepairAllocatededTime).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RepairDescription).HasMaxLength(1020);

                entity.Property(e => e.RepairName).HasMaxLength(255);

                entity.Property(e => e.RepairType).HasMaxLength(255);

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VehicleFuel).HasMaxLength(50);

                entity.Property(e => e.Vin).HasMaxLength(255);
            });

            modelBuilder.Entity<ImportSeed>(entity =>
            {
                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.Derivative).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Make).HasMaxLength(255);

                entity.Property(e => e.Mobile).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Reg).HasMaxLength(255);

                entity.Property(e => e.RepairDescription).HasMaxLength(255);

                entity.Property(e => e.RepairName).HasMaxLength(255);

                entity.Property(e => e.RepairType).HasMaxLength(255);

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Vin).HasMaxLength(255);
            });

            modelBuilder.Entity<ImportStaging>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(1000);

                entity.Property(e => e.Address3).HasMaxLength(100);

                entity.Property(e => e.Address4).HasMaxLength(100);

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.Derivative).HasMaxLength(255);

                entity.Property(e => e.Dmsadvisor)
                    .HasColumnName("DMSAdvisor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DmsadvisorId).HasColumnName("DMSAdvisorId");

                entity.Property(e => e.DmscustomerId).HasColumnName("DMSCustomerId");

                entity.Property(e => e.Dmsid).HasColumnName("DMSId");

                entity.Property(e => e.DmsrepairId).HasColumnName("DMSRepairId");

                entity.Property(e => e.DmsvehicleId).HasColumnName("DMSVehicleId");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.ImportStagingHeaderId).HasColumnName("importStagingHeaderID");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Make).HasMaxLength(255);

                entity.Property(e => e.Mobile).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.Postcode).HasMaxLength(20);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Reg).HasMaxLength(255);

                entity.Property(e => e.RepairAllocatededTime).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RepairDescription).HasMaxLength(1020);

                entity.Property(e => e.RepairName).HasMaxLength(255);

                entity.Property(e => e.RepairType).HasMaxLength(255);

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VehicleFuel).HasMaxLength(50);

                entity.Property(e => e.Vin).HasMaxLength(255);
            });

            modelBuilder.Entity<ImportStagingHeader>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('Pending')");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.ImportStagingHeader)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fK_importStagingHeader_ImportStagingHeaderStatus");
            });

            modelBuilder.Entity<ImportStagingHeaderStatus>(entity =>
            {
                entity.HasKey(e => e.Status)
                    .HasName("PK__ImportSt__3A15923E4605A58F");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<IncrementType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_IncrementType_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntegrationType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<IntegrationUpdateRequest>(entity =>
            {
                entity.Property(e => e.ReferenceContextId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceContextType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.IntegrationUpdateRequest)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntegrationUpdateRequest_GarageId");
            });

            modelBuilder.Entity<InternalNote>(entity =>
            {
                entity.Property(e => e.ActionedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InternalNote)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternalNote_CreatedBy");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.InternalNote)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternalNote_JobId");
            });

            modelBuilder.Entity<IntervalType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasIndex(e => e.AccountId);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.GarageId);

                entity.HasIndex(e => e.GarageItemTypeId);

                entity.HasIndex(e => e.JobId);

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.RepairId);

                entity.HasIndex(e => e.ReplicationId)
                    .HasName("IDX_Item_ReplicationId");

                entity.HasIndex(e => e.TaxGroupId);

                entity.HasIndex(e => e.UpdatedBy);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ReplicationId).HasColumnName("ReplicationID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_AccountId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ItemCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_CreatedBy");

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.CurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_CurrencyCode");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_GarageId");

                entity.HasOne(d => d.GarageItemType)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.GarageItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_GarageItemTypeId");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_JobId");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_Item_MapReferenceContainer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Item_ProductId");

                entity.HasOne(d => d.Repair)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.RepairId)
                    .HasConstraintName("FK_Item_RepairId");

                entity.HasOne(d => d.TaxGroup)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.TaxGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_TaxGroupId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ItemUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_UpdatedBy");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasIndex(e => e.ContactId);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.DeletedBy);

                entity.HasIndex(e => e.GarageId);

                entity.HasIndex(e => e.UpdatedBy);

                entity.HasIndex(e => e.VehicleId);

                entity.HasIndex(e => new { e.GarageId, e.Number })
                    .HasName("UQ_Job_GarageId_Number")
                    .IsUnique();

                entity.Property(e => e.Completed).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeclinedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Estimated).HasColumnType("datetime");

                entity.Property(e => e.In).HasColumnType("datetime");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Out).HasColumnType("datetime");

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_ContactId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.JobCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_CreatedBy");

                entity.HasOne(d => d.DeclinedByNavigation)
                    .WithMany(p => p.JobDeclinedByNavigation)
                    .HasForeignKey(d => d.DeclinedBy)
                    .HasConstraintName("FK_Job_DeclinedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.JobDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Job_DeletedBy");

                entity.HasOne(d => d.FileGrouping)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.FileGroupingId)
                    .HasConstraintName("FK_Job_FileGrouping");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_GarageId");

                entity.HasOne(d => d.GarageJobStatusLevel)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.GarageJobStatusLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_GarageJobStatusLevelId");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_Job_MapReferenceContainer");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.JobUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_UpdatedBy");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_VehicleId");
            });

            modelBuilder.Entity<JobAssignee>(entity =>
            {
                entity.HasIndex(e => new { e.JobId, e.PositionId, e.Start })
                    .HasName("UQ_JobAssignee_JobId_PositionId_Start")
                    .IsUnique();

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.GarageUser)
                    .WithMany(p => p.JobAssignee)
                    .HasForeignKey(d => d.GarageUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobAssignee_GarageUserId");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobAssignee)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobAssignee_JobId");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.JobAssignee)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobAssignee_PositionId");
            });

            modelBuilder.Entity<JobChat>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.JobChat)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobChat_ContactId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.JobChatCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobChat_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.JobChatDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_JobChat_DeletedBy");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobChat)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobChat_JobId");
            });

            modelBuilder.Entity<JobMessage>(entity =>
            {
                entity.HasIndex(e => e.JobId);

                entity.Property(e => e.ActionedDate).HasColumnType("datetime");

                entity.Property(e => e.Attachment).HasMaxLength(500);

                entity.Property(e => e.ContactAddress)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Content).HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerReadDate).HasColumnType("datetime");

                entity.Property(e => e.MetaData).HasMaxLength(255);

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.Property(e => e.StatusMessage)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.JobMessage)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobMessage_CreatedBy");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobMessage)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobMessage_JobId");
            });

            modelBuilder.Entity<JobMetaData>(entity =>
            {
                entity.HasIndex(e => e.JobId);

                entity.HasIndex(e => e.MetadataTypeId);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobMetaData)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobMetaData_JobId");

                entity.HasOne(d => d.MetadataType)
                    .WithMany(p => p.JobMetaData)
                    .HasForeignKey(d => d.MetadataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobMetaData_MetadataTypeId");
            });

            modelBuilder.Entity<JobStatusLevel>(entity =>
            {
                entity.HasIndex(e => e.JobSuperStatusLevelId);

                entity.HasIndex(e => e.Name)
                    .HasName("UQ_JobStatusLevel_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.JobSuperStatusLevel)
                    .WithMany(p => p.JobStatusLevel)
                    .HasForeignKey(d => d.JobSuperStatusLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobStatusLevel_Id");
            });

            modelBuilder.Entity<JobSuperStatusLevel>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_JobSuperStatusLevel_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<KeeDerivative>(entity =>
            {
                entity.ToTable("KeeDerivative", "VehicleLookup");

                entity.HasIndex(e => new { e.ModelId, e.Name })
                    .HasName("IX_ModelIdName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.KeeDerivative)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeeDerivative_Model");
            });

            modelBuilder.Entity<KeeMake>(entity =>
            {
                entity.ToTable("KeeMake", "VehicleLookup");

                entity.HasIndex(e => e.Name);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<KeeModel>(entity =>
            {
                entity.ToTable("KeeModel", "VehicleLookup");

                entity.HasIndex(e => new { e.MakeId, e.Name })
                    .HasName("IX_KeeModel_MakeIdName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Make)
                    .WithMany(p => p.KeeModel)
                    .HasForeignKey(d => d.MakeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeeModel_Make");
            });

            modelBuilder.Entity<LoungeJob>(entity =>
            {
                entity.HasIndex(e => e.AuthenticationCode);

                entity.HasIndex(e => e.GarageId);

                entity.HasIndex(e => e.Reference);

                entity.Property(e => e.AuthenticationCode)
                    .IsRequired()
                    .HasMaxLength(155);

                entity.Property(e => e.ValidEnd).HasColumnType("datetime");

                entity.Property(e => e.ValidStart).HasColumnType("datetime");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.LoungeJob)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoungeJob_GarageId");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.LoungeJob)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoungeJob_JobId");

                entity.HasOne(d => d.JobMessage)
                    .WithMany(p => p.LoungeJob)
                    .HasForeignKey(d => d.JobMessageId)
                    .HasConstraintName("FK_LoungeJob_JobMessageId");
            });

            modelBuilder.Entity<Make>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Map>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceContext)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ReferenceContextType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MapCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Map_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.MapDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Map_DeletedBy");

                entity.HasOne(d => d.IntegrationType)
                    .WithMany(p => p.Map)
                    .HasForeignKey(d => d.IntegrationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Map_IntegrationTypeId");

                entity.HasOne(d => d.ReferenceObjectType)
                    .WithMany(p => p.Map)
                    .HasForeignKey(d => d.ReferenceObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Map_ReferenceObjectTypeId");

                entity.HasOne(d => d.RootGarage)
                    .WithMany(p => p.Map)
                    .HasForeignKey(d => d.RootGarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Map_RootGarageId");
            });

            modelBuilder.Entity<MapReference>(entity =>
            {
                entity.HasKey(e => new { e.MapReferenceContainerId, e.MapId });

                entity.HasOne(d => d.Map)
                    .WithMany(p => p.MapReference)
                    .HasForeignKey(d => d.MapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MapReference_Map");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.MapReference)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MapReference_MapReferenceContainer");
            });

            modelBuilder.Entity<MenuPriceType>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<MessageReminder>(entity =>
            {
                entity.Property(e => e.ActionedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.ReminderDate).HasColumnType("datetime");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.MessageReminder)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MessageReminder_Job");
            });

            modelBuilder.Entity<MessageReminderInternalNote>(entity =>
            {
                entity.HasKey(e => new { e.MessageReminderId, e.InternalNoteId })
                    .HasName("pk_MessageReminderInternalNote");

                entity.HasOne(d => d.InternalNote)
                    .WithMany(p => p.MessageReminderInternalNote)
                    .HasForeignKey(d => d.InternalNoteId)
                    .HasConstraintName("fk_MessageReminderInternalNote_InternalNote");

                entity.HasOne(d => d.MessageReminder)
                    .WithMany(p => p.MessageReminderInternalNote)
                    .HasForeignKey(d => d.MessageReminderId)
                    .HasConstraintName("fk_MessageReminderInternalNote_MessageReminder");
            });

            modelBuilder.Entity<MessageReminderJobMessage>(entity =>
            {
                entity.HasKey(e => new { e.MessageReminderId, e.JobMessageId })
                    .HasName("pk_MessageReminderJobMessage");

                entity.HasOne(d => d.JobMessage)
                    .WithMany(p => p.MessageReminderJobMessage)
                    .HasForeignKey(d => d.JobMessageId)
                    .HasConstraintName("fk_MessageReminderJobMessage_JobMessage");

                entity.HasOne(d => d.MessageReminder)
                    .WithMany(p => p.MessageReminderJobMessage)
                    .HasForeignKey(d => d.MessageReminderId)
                    .HasConstraintName("fk_MessageReminderJobMessage_MessageReminder");
            });

            modelBuilder.Entity<MessageReminderRepairMessage>(entity =>
            {
                entity.HasKey(e => new { e.MessageReminderId, e.RepairMessageId })
                    .HasName("pk_MessageReminderRepairMessage");

                entity.HasOne(d => d.MessageReminder)
                    .WithMany(p => p.MessageReminderRepairMessage)
                    .HasForeignKey(d => d.MessageReminderId)
                    .HasConstraintName("fk_MessageReminderRepairMessage_MessageReminder");

                entity.HasOne(d => d.RepairMessage)
                    .WithMany(p => p.MessageReminderRepairMessage)
                    .HasForeignKey(d => d.RepairMessageId)
                    .HasConstraintName("fk_MessageReminderRepairMessage_RepairMessage");
            });

            modelBuilder.Entity<MetadataCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Metadata_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MetadataType>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.MetadataCategoryId })
                    .HasName("UQ_MetadataType_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasIndex(e => e.Ref)
                    .HasName("UQ__Model__CAF0B45AD3999779")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ref).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Make)
                    .WithMany(p => p.Model)
                    .HasForeignKey(d => d.MakeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Model_Make");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_Module_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OdometerMeasureType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OneTimeScriptsExecuted>(entity =>
            {
                entity.Property(e => e.DurationSeconds)
                    .HasColumnType("numeric(19, 4)")
                    .HasComputedColumnSql("(CONVERT([numeric](19,4),datediff(millisecond,[StartDate],[EndDate])/(1000.0)))");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExecutedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.DeletedBy);

                entity.HasIndex(e => e.GarageId);

                entity.HasIndex(e => e.GarageRepairTypeId);

                entity.HasIndex(e => e.UpdatedBy);

                entity.Property(e => e.BookedTime).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.InternalValue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.OnlinePriceText).HasMaxLength(100);

                entity.Property(e => e.OnlineValue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RequestedNote).IsRequired();

                entity.Property(e => e.RequiredNote).IsRequired();

                entity.Property(e => e.TechnicianNote).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PackageCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Package_CreatedBy");

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.CurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Package_CurrencyCode");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PackageDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Package_DeletedBy");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Package_GarageId");

                entity.HasOne(d => d.GarageRepairType)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.GarageRepairTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Package_GarageRepairTypeId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.PackageUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Package_UpdatedBy");
            });

            modelBuilder.Entity<PackageProduct>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.DeletedBy);

                entity.HasIndex(e => e.PackageId);

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.PurchaseAccountId);

                entity.HasIndex(e => e.PurchaseTaxGroupId);

                entity.HasIndex(e => e.SaleAccountId);

                entity.HasIndex(e => e.SaleTaxGroupId);

                entity.HasIndex(e => e.UpdatedBy);

                entity.HasIndex(e => new { e.PackageId, e.ProductId })
                    .HasName("UQ_PackageProduct_PackageId_ProductId")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.PurchaseValue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SaleCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.SaleValue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PackageProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageProduct_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PackageProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_PackageProduct_DeletedBy");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.PackageProduct)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageProduct_PackageId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PackageProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageProduct_ProductId");

                entity.HasOne(d => d.PurchaseAccount)
                    .WithMany(p => p.PackageProductPurchaseAccount)
                    .HasForeignKey(d => d.PurchaseAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageProduct_PurchaseAccountId");

                entity.HasOne(d => d.PurchaseCurrencyCodeNavigation)
                    .WithMany(p => p.PackageProductPurchaseCurrencyCodeNavigation)
                    .HasForeignKey(d => d.PurchaseCurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageProduct_PurchaseCurrencyCode");

                entity.HasOne(d => d.PurchaseTaxGroup)
                    .WithMany(p => p.PackageProductPurchaseTaxGroup)
                    .HasForeignKey(d => d.PurchaseTaxGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageProduct_PurchaseTaxGroupId");

                entity.HasOne(d => d.SaleAccount)
                    .WithMany(p => p.PackageProductSaleAccount)
                    .HasForeignKey(d => d.SaleAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageProduct_SaleAccountId");

                entity.HasOne(d => d.SaleCurrencyCodeNavigation)
                    .WithMany(p => p.PackageProductSaleCurrencyCodeNavigation)
                    .HasForeignKey(d => d.SaleCurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageProduct_SaleCurrencyCode");

                entity.HasOne(d => d.SaleTaxGroup)
                    .WithMany(p => p.PackageProductSaleTaxGroup)
                    .HasForeignKey(d => d.SaleTaxGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageProduct_SaleTaxGroupId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.PackageProductUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageProduct_UpdatedBy");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ThemeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.PartnerType)
                    .WithMany(p => p.Partner)
                    .HasForeignKey(d => d.PartnerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartnerType_PartnerTypeId");
            });

            modelBuilder.Entity<PartnerType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_PartnerType_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_Permission_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlanTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PlanTemplate)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_PlanTemplate_CountryId");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PlanTemplate)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_PlanTemplate_PartnerId");

                entity.HasOne(d => d.Tier)
                    .WithMany(p => p.PlanTemplate)
                    .HasForeignKey(d => d.TierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanTemplate_TierId");
            });

            modelBuilder.Entity<PlanTemplateFeature>(entity =>
            {
                entity.HasIndex(e => new { e.PlanTemplateId, e.FeatureId })
                    .HasName("UQ_PlanTemplateFeature_PlanTemplateId_FeatureID")
                    .IsUnique();

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.PlanTemplateFeature)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanTemplateFeature_FeatureId");

                entity.HasOne(d => d.PlanTemplate)
                    .WithMany(p => p.PlanTemplateFeature)
                    .HasForeignKey(d => d.PlanTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanTemplateFeature_PlanTemplateId");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_Position_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PowerType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_PowerType_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PreDeployOneTimeScriptsExecuted>(entity =>
            {
                entity.Property(e => e.DurationSeconds)
                    .HasColumnType("numeric(19, 4)")
                    .HasComputedColumnSql("(CONVERT([numeric](19,4),datediff(millisecond,[StartDate],[EndDate])/(1000.0)))");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExecutedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.DeletedBy);

                entity.HasIndex(e => e.GarageId);

                entity.HasIndex(e => e.GarageItemTypeId);

                entity.HasIndex(e => e.PurchaseAccountId);

                entity.HasIndex(e => e.PurchaseTaxGroupId);

                entity.HasIndex(e => e.SaleAccountId);

                entity.HasIndex(e => e.SaleTaxGroupId);

                entity.HasIndex(e => e.UpdatedBy);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.PurchaseCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.PurchaseValue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SaleCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.SaleValue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Product_DeletedBy");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_GarageId");

                entity.HasOne(d => d.GarageItemType)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.GarageItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_GarageItemTypeId");

                entity.HasOne(d => d.PurchaseAccount)
                    .WithMany(p => p.ProductPurchaseAccount)
                    .HasForeignKey(d => d.PurchaseAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_PurchaseAccountId");

                entity.HasOne(d => d.PurchaseCurrencyCodeNavigation)
                    .WithMany(p => p.ProductPurchaseCurrencyCodeNavigation)
                    .HasForeignKey(d => d.PurchaseCurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_PurchaseCurrencyCode");

                entity.HasOne(d => d.PurchaseTaxGroup)
                    .WithMany(p => p.ProductPurchaseTaxGroup)
                    .HasForeignKey(d => d.PurchaseTaxGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_PurchaseTaxGroupId");

                entity.HasOne(d => d.SaleAccount)
                    .WithMany(p => p.ProductSaleAccount)
                    .HasForeignKey(d => d.SaleAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_SaleAccountId");

                entity.HasOne(d => d.SaleCurrencyCodeNavigation)
                    .WithMany(p => p.ProductSaleCurrencyCodeNavigation)
                    .HasForeignKey(d => d.SaleCurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_SaleCurrencyCode");

                entity.HasOne(d => d.SaleTaxGroup)
                    .WithMany(p => p.ProductSaleTaxGroup)
                    .HasForeignKey(d => d.SaleTaxGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_SaleTaxGroupId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ProductUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_UpdatedBy");
            });

            modelBuilder.Entity<ReferenceObjectType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RegistrationStatus>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_RegistrationStatus_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ReminderCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Reminder_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ReminderType>(entity =>
            {
                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => new { e.Name, e.ReminderCategoryId })
                    .HasName("UQ_ReminderType_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Repair>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.DeletedBy);

                entity.HasIndex(e => e.GarageRepairTypeId);

                entity.HasIndex(e => e.JobId);

                entity.HasIndex(e => e.PackageId);

                entity.HasIndex(e => e.ReplicationId)
                    .HasName("IDX_Repair_ReplicationId");

                entity.HasIndex(e => e.UpdatedBy);

                entity.Property(e => e.BookedTime).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.In).HasColumnType("datetime");

                entity.Property(e => e.Out).HasColumnType("datetime");

                entity.Property(e => e.RepairName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ReplicationId).HasColumnName("ReplicationID");

                entity.Property(e => e.RequestedNote).IsRequired();

                entity.Property(e => e.RequiredNote).IsRequired();

                entity.Property(e => e.TechnicianNote).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RepairCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Repair_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.RepairDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Repair_DeletedBy");

                entity.HasOne(d => d.GarageRepairType)
                    .WithMany(p => p.Repair)
                    .HasForeignKey(d => d.GarageRepairTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Repair_GarageRepairTypeId");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Repair)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Repair_JobId");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.Repair)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_Repair_MapReferenceContainer");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Repair)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_Repair_PackageId");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Repair)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_Repair_ResourceId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.RepairUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Repair_UpdatedBy");
            });

            modelBuilder.Entity<RepairMessage>(entity =>
            {
                entity.Property(e => e.ActionedDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MetaData).HasMaxLength(255);

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RepairMessage)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairMessage_CreatedBy");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.RepairMessage)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairMessage_JobId");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.RepairMessage)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairMessage_PackageId");
            });

            modelBuilder.Entity<RepairType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasIndex(e => e.GarageId);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Ref).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ResourceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resource_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ResourceDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Resource_DeletedBy");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resource_Garageid");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ResourceUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resource_UpdatedBy");
            });

            modelBuilder.Entity<ResourceAvailability>(entity =>
            {
                entity.HasIndex(e => e.ResourceId);

                entity.HasIndex(e => new { e.ResourceId, e.DayOfWeek })
                    .HasName("UQ_ResourceAvailability_ResourceId_DayOfWeek")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ResourceAvailabilityCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceAvailability_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ResourceAvailabilityDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_ResourceAvailability_DeletedBy");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceAvailability)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceAvailability_ResourceId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ResourceAvailabilityUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceAvailability_UpdatedBy");
            });

            modelBuilder.Entity<ResourceAvailabilityPackage>(entity =>
            {
                entity.HasOne(d => d.Package)
                    .WithMany(p => p.ResourceAvailabilityPackage)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceAvailabilityPackage_PackageId");

                entity.HasOne(d => d.ResourceAvailability)
                    .WithMany(p => p.ResourceAvailabilityPackage)
                    .HasForeignKey(d => d.ResourceAvailabilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceAvailabilityPackage_ResourceAvailabilityId");
            });

            modelBuilder.Entity<ResourceRepairType>(entity =>
            {
                entity.HasIndex(e => e.ResourceId);

                entity.HasOne(d => d.GarageRepairType)
                    .WithMany(p => p.ResourceRepairType)
                    .HasForeignKey(d => d.GarageRepairTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceRepairType_GarageRepairTypeId");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceRepairType)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceRepairType_ResourceId");
            });

            modelBuilder.Entity<SchemaVersions>(entity =>
            {
                entity.Property(e => e.Applied).HasColumnType("datetime");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Summary>(entity =>
            {
                entity.HasIndex(e => new { e.GarageId, e.SummaryDate, e.SummaryTypeId })
                    .HasName("IX_Summary_GarageIdSummaryDateSummaryTypeId");

                entity.HasIndex(e => new { e.GarageId, e.EnquiryPartnerId, e.SummaryDate, e.SummaryTypeId })
                    .HasName("UQ_Summary_GarageId_EnquiryPartnerId_SummaryId_SummaryTypeId")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SummaryDate).HasColumnType("date");

                entity.Property(e => e.Value).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Summary)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Summary_CreatedBy");

                entity.HasOne(d => d.EnquiryPartner)
                    .WithMany(p => p.Summary)
                    .HasForeignKey(d => d.EnquiryPartnerId)
                    .HasConstraintName("FK_Summary_EnquiryPartnerId");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Summary)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Summary_GarageId");

                entity.HasOne(d => d.SummaryType)
                    .WithMany(p => p.Summary)
                    .HasForeignKey(d => d.SummaryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Summary_SummaryTypeId");
            });

            modelBuilder.Entity<SummaryType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxGroup>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DeletedBy).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.TaxGroup)
                    .HasForeignKey(d => d.GarageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxGroup_Garage");
            });

            modelBuilder.Entity<TaxGroupRate>(entity =>
            {
                entity.HasKey(e => new { e.TaxGroupId, e.TaxRateId, e.TaxRateTypeId });
            });

            modelBuilder.Entity<TaxRate>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TaxRate)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxRate_Account");
            });

            modelBuilder.Entity<TaxRateHistory>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.TaxRate)
                    .WithMany(p => p.TaxRateHistory)
                    .HasForeignKey(d => d.TaxRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxRateHistory_TaxRate");
            });

            modelBuilder.Entity<TaxRateType>(entity =>
            {
                entity.HasIndex(e => e.Name);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Theme>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EmailTemplateLabel).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ThemeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Theme_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ThemeDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Theme_DeletedBy");

                entity.HasOne(d => d.ThemeGroup)
                    .WithMany(p => p.Theme)
                    .HasForeignKey(d => d.ThemeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Theme_ThemeGroup");

                entity.HasOne(d => d.ThemeType)
                    .WithMany(p => p.Theme)
                    .HasForeignKey(d => d.ThemeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Theme_ThemeType");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ThemeUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Theme_UpdatedBy");
            });

            modelBuilder.Entity<ThemeGroup>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ThemeGroupCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThemeGroup_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ThemeGroupDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_ThemeGroup_DeletedBy");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ThemeGroupUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThemeGroup_UpdatedBy");
            });

            modelBuilder.Entity<ThemeType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tier>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TimeZoneId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimelineItemStatus>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.BodyStyle).HasMaxLength(50);

                entity.Property(e => e.Colour).HasMaxLength(25);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Derivative).HasMaxLength(100);

                entity.Property(e => e.Doors).HasMaxLength(25);

                entity.Property(e => e.DriveType).HasMaxLength(25);

                entity.Property(e => e.EngineCapacity).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.EngineCode).HasMaxLength(25);

                entity.Property(e => e.EngineNo).HasMaxLength(25);

                entity.Property(e => e.Gearbox).HasMaxLength(25);

                entity.Property(e => e.GearboxNo).HasMaxLength(25);

                entity.Property(e => e.Make).HasMaxLength(100);

                entity.Property(e => e.ManufactureDate).HasColumnType("datetime");

                entity.Property(e => e.Model).HasMaxLength(100);

                entity.Property(e => e.Power).HasMaxLength(25);

                entity.Property(e => e.ProductionDate).HasColumnType("datetime");

                entity.Property(e => e.RegNo).HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.Trim).HasMaxLength(25);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VinNo).HasMaxLength(25);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VehicleCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.VehicleDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_Vehicle_DeletedBy");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.FuelTypeId)
                    .HasConstraintName("FK_Vehicle_FuelType");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_Vehicle_MapReferenceContainer");

                entity.HasOne(d => d.OdometerMeasureType)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.OdometerMeasureTypeId)
                    .HasConstraintName("FK_Vehicle_OdometerMeasureType");

                entity.HasOne(d => d.PowerType)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.PowerTypeId)
                    .HasConstraintName("FK_Vehicle_PowerType");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.VehicleUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_UpdatedBy");
            });

            modelBuilder.Entity<VehicleClassification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.HasOne(d => d.EnquiryPartner)
                    .WithMany(p => p.VehicleClassification)
                    .HasForeignKey(d => d.EnquiryPartnerId)
                    .HasConstraintName("fk_VehicleClassification_EnquiryPartner");
            });

            modelBuilder.Entity<VehicleClassificationRelation>(entity =>
            {
                entity.HasKey(e => new { e.VehicleClassificationId, e.ModelId })
                    .HasName("PK_VehicleClassificationRelation_ModelID");

                entity.Property(e => e.VehicleClassificationId).HasColumnName("VehicleClassificationID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.VehicleClassificationRelation)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("fk_VehicleClassficationRelation_Model");

                entity.HasOne(d => d.VehicleClassification)
                    .WithMany(p => p.VehicleClassificationRelation)
                    .HasForeignKey(d => d.VehicleClassificationId)
                    .HasConstraintName("fk_VehicleClassificationRelation_VehicleClassification");
            });

            modelBuilder.Entity<VehicleContactHistory>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.VehicleContactHistory)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleContactHistory_Contact");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.VehicleContactHistory)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleContactHistory_ContactType");

                entity.HasOne(d => d.MapReferenceContainer)
                    .WithMany(p => p.VehicleContactHistory)
                    .HasForeignKey(d => d.MapReferenceContainerId)
                    .HasConstraintName("FK_VehicleContactHistory_MapReferenceContainer");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleContactHistory)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleContactHistory_Vehicle");
            });

            modelBuilder.Entity<VehicleLookupType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_VehicleLookupType_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VehicleMetadata>(entity =>
            {
                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.MetadataType)
                    .WithMany(p => p.VehicleMetadata)
                    .HasForeignKey(d => d.MetadataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleMetadata_MetadataType");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleMetadata)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleMetadata_Vehicle");
            });

            modelBuilder.Entity<VehicleMileageHistory>(entity =>
            {
                entity.Property(e => e.RecordedDate).HasColumnType("datetime");

                entity.HasOne(d => d.OdometerMeasureType)
                    .WithMany(p => p.VehicleMileageHistory)
                    .HasForeignKey(d => d.OdometerMeasureTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleMileageHistory_OdometerMeasureType");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleMileageHistory)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleMileageHistory_Vehicle");
            });

            modelBuilder.Entity<VehicleReminder>(entity =>
            {
                entity.Property(e => e.DateFor).HasColumnType("datetime");

                entity.Property(e => e.TriggerDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<YmmeDataOne>(entity =>
            {
                entity.ToTable("YMME_DataOne", "VehicleLookup");

                entity.HasIndex(e => new { e.Year, e.Make, e.Model, e.Trim });

                entity.Property(e => e.Make)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trim)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
