using System;
using System.Collections.Generic;
using System.Text;

namespace AutinoConnect.Hub.Services.Exceptions
{
    public class GarageNotFoundForPartnerException : Exception
    {


        public GarageNotFoundForPartnerException()
        {
        }

        public GarageNotFoundForPartnerException(string message)
            : base(message)
        {
        }

        public GarageNotFoundForPartnerException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
