import React, { Component } from 'react';
import { YourDetails } from './DetailsPannel/YourDetails';
import { BookingInfo } from './DetailsPannel/BookingInfo';
import { HavingDone } from './DetailsPannel/HavingDone';
import { Repair } from './DetailsPannel/Repair';
export class  BookingDetailsPanel extends React.Component {
    render() {
        let { booking } = this.props;
        return (
      
            <div className="small-12 medium-3 column mobile-page hide-for-small-only" id="pageDetails">
                    <ul className="accordion" data-accordion data-allow-all-closed="true" data-multi-expand="true">

            <BookingInfo booking={booking} />
            <YourDetails booking={booking} />
             <HavingDone booking={booking} />
            </ul>
                </div>
            
            
    );
}
}