using System;
using System.Collections.Generic;
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

        public BookingExtendedModel()
        {
            Repairs = new List<RepairExtended>();
        }
    }

    public class RepairExtended
    {
        public string Name { get; set; }
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
