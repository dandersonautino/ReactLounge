using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autino.Lounge.Services.Interfaces;
using Autino.Lounge.Services.Models.Booking;
using Microsoft.AspNetCore.Mvc;

namespace reactlounge.Controllers
{
    [Route("[controller]")]
    public class TokenController : Controller
    {
        [HttpGet("[action]")]
        public RedirectResult Get(string token)
        {
            try
            {
            
               var model= _tokenService.ValidateToken(token);
                return new RedirectResult("~/");
            }
            catch (Exception e)
            {
                //TODO error handling expireed token etc
                Console.WriteLine(e);
                throw;
            }
           
        }

        public TokenController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        private readonly ITokenService _tokenService;
    }
}
