using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autino.Lounge.Services.Interfaces;
using Autino.Lounge.Services.Models.Booking;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace reactlounge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet("[action]")]
        public async  Task<BookingModel> GetBooking()
        {///Todo Secure me
         /// Todo dont hard code me
            Guid bookingRef = new Guid("DEAD52BA-1335-4A96-B116-641BC67B13DD");
            Guid garageRef = new Guid("50DDB444-1BF1-4D1D-87F1-8F89932569CB");
            return await _bookingService.GetBooking(bookingRef,garageRef );
        }

        private readonly IBookingService _bookingService;
    }
}