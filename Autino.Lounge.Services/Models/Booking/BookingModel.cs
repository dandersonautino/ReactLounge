/**
* Copyright: (C) Autino 2017
*
* IP owned by Autino Ltd. This software is CONFIDENTIAL to Autino Ltd. It is not to be stored
* with third parties without written permission and consent and a non-disclosure agreement in place.
**/

using System;
using System.Collections.Generic;

namespace Autino.Lounge.Services.Models.Booking
{
    public class BookingModel
    {
        public BookingModel()
        {
            Packages = new List<BookingPackageModel>();
        }

        public Guid Ref { get; set; }

        public DateTime BookingDateTime { get; set; }

        public BookingContactModel Contact { get; set; }
        
        public BookingVehicleModel Vehicle { get; set; }

        public List<BookingPackageModel> Packages { get; set; }

        public string Status { get; set; }

        public string JobStatus { get; set; }
    }
}