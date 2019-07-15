import React, { Component } from 'react';
import { Repair } from './Repair';
export class HavingDone extends React.Component {
    render() {
        let { booking } = this.props;
        return (
        <li className="accordion-item repairs is-active" data-accordion-item>
             <a href="#" className="accordion-title">What you're having done</a>
            <div class="accordion-content" data-tab-content>
                    {booking.repairs.map((repair, i) => {
            return (<Repair key={i} repair={repair} />)
        })}
            </div>
         </li>
    );
}
}