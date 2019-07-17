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
        public async  Task<BookingExtendedModel> GetBooking()
        {///Todo Secure me
         /// Todo dont hard code me
            Guid bookingRef = new Guid("DEAD52BA-1335-4A96-B116-641BC67B13DD");
            Guid garageRef = new Guid("50DDB444-1BF1-4D1D-87F1-8F89932569CB");
            var  model = await _bookingService.GetBooking(bookingRef, garageRef);
            model.InviteExpired = false;
            model.Repairs.Add(new RepairExtended(){Name="Change exhaust"});
            model.Repairs.Add(new RepairExtended() { Name = "Check Types" });
            model.Garage = new GarageModel()
            {
                Name = "dave's garage",
                Address1 ="add1",
                Address2 = "add2",
                Address3 = "add3",
                PostCode = "RG1 2LR"
            };
            model.ChatToken =
                "H4sIAAAAAAAEAAXBSxKCIAAA0AOxUCOSFm600rEEU4txWWgOYajlD07fe4Xh1smoJG2xSXkZNHjEgNDuLIXQGxxHD9aAGiwROghEW2Lsd4KNmnoV5lcI0ch6PZoqK6YdtyVZRKin++0Zxi2Rzj7i3bwqn5HA/znZ4G5fYQXjNjnO5XqxEq3ZB9McTinSLv/S1AK17MmweN4fI9nOYpgAAAA=";
            return model;
        }

        

        private readonly IBookingService _bookingService;
    }
}