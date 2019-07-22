import React, { Component } from 'react';
import GetTranslations from '../..//Resources/GetTranslations';
export class YourDetails extends React.Component {
    render() {
        let { booking } = this.props;
        let    strings = GetTranslations().SetLanguage(booking.language);
        return (
    <li className="accordion-item" data-accordion-item>
    <a href="#" className="accordion-title">{strings.YourDetails}</a>
    <div className="accordion-content" data-tab-content>
    {booking.contact.firstName} <br />
    {booking.vehicle.make}  {booking.vehicle.model} l {booking.vehicle.derivative} <br />
    {booking.vehicle.regNo}
    </div>
            </li>
            );
    }
}