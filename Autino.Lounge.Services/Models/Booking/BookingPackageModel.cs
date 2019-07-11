/**
* Copyright: (C) Autino 2017
*
* IP owned by Autino Ltd. This software is CONFIDENTIAL to Autino Ltd. It is not to be stored
* with third parties without written permission and consent and a non-disclosure agreement in place.
**/

using System;

namespace Autino.Lounge.Services.Models.Booking
{
    public class BookingPackageModel
    {
        /// <summary>
        /// The ref of the EnquiryPartnerPackage so we can look it up
        /// </summary>
        public Guid Ref { get; set; }

        /// <summary>
        /// The override details to allow us to add ad-hoc information to the repair header
        /// </summary>
        public string Details { get; set; }

        public Guid? VehicleClassificationRef { get; set; }
    }
}