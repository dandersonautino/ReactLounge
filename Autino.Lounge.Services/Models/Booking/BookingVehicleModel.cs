/**
* Copyright: (C) Autino 2017
*
* IP owned by Autino Ltd. This software is CONFIDENTIAL to Autino Ltd. It is not to be stored
* with third parties without written permission and consent and a non-disclosure agreement in place.
**/

using System;

namespace Autino.Lounge.Services.Models.Booking
{
    public class BookingVehicleModel
    {
        public Guid? Ref { get; set; }

        public string RegNo { get; set; }
        
        public string Make { get; set; }
        public string Model { get; set; }
        public string Derivative { get; set; }
    }
}