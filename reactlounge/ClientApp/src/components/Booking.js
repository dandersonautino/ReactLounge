import { BookingDetailsPanel } from 'BookingDetailsPanel';
import React, { Component } from 'react';


export class Booking extends Component {
    static displayName = Booking.name;

    constructor(props) {
        super(props);
        this.state = { booking: [], loading: true };

        fetch('api/booking/getbooking')
            .then(response => response.json())
            .then(data => {
                this.setState({ booking: data, loading: false });
            });
    }

    static renderBooking(booking) {
        return (
            <BookingDetailsPanel booking={booking} />
);
}

render() {
    let contents = this.state.loading
        ? <p><em>Loading...</em></p>
        : Booking.renderBooking(this.state.booking);

    return (
        <div>
        <h1>Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
        </div>
);
}
}
