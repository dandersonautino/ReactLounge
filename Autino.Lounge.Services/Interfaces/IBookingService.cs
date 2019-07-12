using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autino.Lounge.Services.Models.Booking;

namespace Autino.Lounge.Services.Interfaces
{
   public interface IBookingService
   {
       Task<BookingExtendedModel> GetBooking(Guid bookingRef, Guid garageRef);
   }
}
