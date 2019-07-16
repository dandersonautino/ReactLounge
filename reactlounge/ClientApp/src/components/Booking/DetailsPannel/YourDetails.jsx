import React, { Component } from 'react';
export class YourDetails extends React.Component {
    render() {
        let { booking } = this.props;
        return (
    <li className="accordion-item" data-accordion-item>
    <a href="#" className="accordion-title">YourDetails</a>
    <div className="accordion-content" data-tab-content>
    {booking.contact.firstName} <br />
    {booking.vehicle.make}  {booking.vehicle.model} l {booking.vehicle.derivative} <br />
    {booking.vehicle.regNo}
    </div>
            </li>
            );
    }
}