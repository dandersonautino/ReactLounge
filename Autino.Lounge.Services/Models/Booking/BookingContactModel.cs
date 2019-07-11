/**
* Copyright: (C) Autino 2017
*
* IP owned by Autino Ltd. This software is CONFIDENTIAL to Autino Ltd. It is not to be stored
* with third parties without written permission and consent and a non-disclosure agreement in place.
**/

using System;

namespace Autino.Lounge.Services.Models.Booking
{
    public class BookingContactModel
    {
        public Guid? Ref { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
    }
}