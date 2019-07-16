import { BookingDetailsPanel } from './BookingDetailsPanel';
import { ExpiredBooking } from './ExpiredBooking';
import { ChatContainer } from './Chat/ChatContainer';
import React, { Component } from 'react';
import { GarageInfo } from './GarageInfo';

export class Booking extends Component {
 

    constructor(props) {
        super(props);
        this.state = { booking: [], loading: true };

        fetch(process.env.REACT_APP_API_PREFIX+'/api/booking/getbooking')
            .then(response => response.json())
            .then(data => {
                this.setState({ booking: data, loading: false });
            });
    }

    static renderBooking(booking) {
        if (booking.inviteExpired) {
            return (   <ExpiredBooking />);
        } else {
            return (
            <div className="row hero" data-equalizer-watch>
                <BookingDetailsPanel booking={booking} />
                <ChatContainer booking={booking} />
                <GarageInfo booking={booking} />
                </div>
    );
}
}

render() {
    let contents = this.state.loading
        ? <p><em>Loading...</em></p>
        : Booking.renderBooking(this.state.booking);

    return (
       <div>
            {contents}
    </div>
       
);
}
}
