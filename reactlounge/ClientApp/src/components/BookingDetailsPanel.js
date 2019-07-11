import React, { Component } from 'react';
class BookingDetailsPanel extends React.Component {
    render() {
        let { booking } = this.props;
        return (
        <div class="row hero" data-equalizer-watch>
            <div class="small-12 medium-3 column mobile-page hide-for-small-only" id="pageDetails">
            <ul class="accordion" data-accordion data-allow-all-closed="true" data-multi-expand="true">
            <li class="accordion-item" data-accordion-item>
            <a href="#" class="accordion-title">YourDetails</a>
            <div class="accordion-content" data-tab-content>
            {booking.contact.firstName} <br />
            {booking.vehicle.make}  {booking.vehicle.model} l {booking.vehicle.derivative} <br />
            {booking.vehicle.regNo}
            </div>
            </li>
            </ul>
            </div>
            </div>
    );
}
}