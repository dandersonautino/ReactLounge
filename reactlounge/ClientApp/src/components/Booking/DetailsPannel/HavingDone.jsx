import React, { Component } from 'react';
import { Repair } from './Repair';
import GetTranslations from '../..//Resources/GetTranslations';
export class HavingDone extends React.Component {
    render() {
        let { booking } = this.props;
        let    strings = GetTranslations().SetLanguage(booking.language);
        return (
        <li className="accordion-item repairs is-active" data-accordion-item>
             <a href="#" className="accordion-title">{strings.Lounge_WhatYoureHavingDone}</a>
            <div className="accordion-content" data-tab-content>
                    {booking.repairs.map((repair, i) => {
            return (<Repair key={i} repair={repair} />)
        })}
            </div>
         </li>
    );
}
}