using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autino.Lounge.Services.Interfaces;
using Autino.Lounge.Services.Models.Booking;
using AutinoConnect.Shared.Connectivity.Interfaces;

namespace Autino.Lounge.Services.Concrete
{
    public class BookingService :ApiServiceBase  ,IBookingService
    {
        public  async Task<BookingModel> GetBooking(Guid bookingRef, Guid garageRef)
        {
           
            var client = await GetClient($"api/booking/{bookingRef}");

            var response = await client 
                .AddCustomHeader("X-BAYCONNECT-GARAGEREF", garageRef.ToString())
                .GetAsyncAndGetResponse<BookingModel>();
            return response;
       
        }
        public BookingService(IWebApiClientManager webApiClientManager, IIdentityTokenService identityTokenService, IConfigurationService configurationService) : base(webApiClientManager,identityTokenService, configurationService)
        {

        }
    }
  
}
