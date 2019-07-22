using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using AutinoConnect.Shared.Model.Garage;

namespace Autino.Lounge.Services.Models.Booking
{
   public class BookingExtendedModel : BookingModel
    {
       

        public bool InviteExpired { get; set; }
        public string DateIn => DateTime.Now.ToString("dd") + " " + new DateTimeFormatInfo().GetMonthName(DateTime.Now.Month) + " " + DateTime.Now.ToString("yyyy");
        public string DateOut => DateTime.Now.AddHours(4).ToString("dd") + " " + new DateTimeFormatInfo().GetMonthName(DateTime.Now.Month) + " " + DateTime.Now.ToString("yyyy");
      
        public string TimeIn => DateTime.Now.ToString("hh:mm");
        public string TimeOut => DateTime.Now.AddHours(4).ToString("hh:mm");
        public List<RepairExtended> Repairs { get; set; }
        public GarageModel Garage { get; set; }
        public string ChatToken { get; set; }
        public string UtcOffset { get; set; }

       
        public List<GarageCommunicationMethodViewModel> GarageCommunications { get; set; }
        public string TermsAndConditions { get; set; }
        public bool ShowTermsAndConditions { get; set; }
        public string VatNumber { get; set; }
        public string CompanyNumber { get; set; }
        public List<GarageOpeningTime> OpeningHours { get; set; }
        public Facilities Facilities { get; set; }
        public string Language { get; set; }

        public BookingExtendedModel()
        {
            Repairs = new List<RepairExtended>();
            OpeningHours = new List<GarageOpeningTime>();
            GarageCommunications = new List<GarageCommunicationMethodViewModel>();

        }
    }
    [Flags]
    public enum Facilities
    {
        [Description("Reception Waiting Area")]
        Reception = 1,

        [Description("Customer Toilets")]
        Toilets = 2,

        [Description("Free Wifi")]
        Wifi = 4,

        [Description("Hot & Cold Refreshments")]
        Refreshments = 8,

        [Description("Workshop Viewing Window")]
        Viewing = 16,

        [Description("Food & Snacks Available Nearby")]
        Snacks = 32,

        [Description("TV")]
        TV = 64,

        [Description("Magazine")]
        Magazines = 128,

        [Description("Disabled Access")]
        DisabledAccess = 256,

        [Description("Off Street Parking")]
        Parking = 512
    }
    public enum CommunicationMethodType
    {
        [Description("Email")]
        Email = 1,

        [Description("Telephone")]
        Telephone = 2,

        [Description("Mobile")]
        Mobile = 3,

        [Description("Work Phone")]
        OfficePhone = 4,

        [Description("Google+")]
        Google = 5,

        [Description("Facebook")]
        Facebook = 6,

        [Description("Twitter")]
        Twitter = 7,

        [Description("Skype")]
        Skype = 8,

        [Description("LinkedIn")]
        LinkedIn = 9,

        [Description("Website")]
        Website = 10,

        [Description("Fax")]
        Fax = 11
    }
    public class GarageCommunicationMethodViewModel
    {
        public string ContactMethodType { get; set; }
       
        public string Value { get; set; }
    }
    public class RepairExtended
    {
        public string Name { get; set; }
    }
    public class GarageOpeningTime
    {
        public int Id { get; set; }
        public int GarageId { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public int DayOfWeek { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

    }
    public class GarageModel
    {
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string PostCode { get; set; }
    }
}
