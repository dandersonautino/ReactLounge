import { BookingDetailsPanel } from './BookingDetailsPanel';
import { ExpiredBooking } from './ExpiredBooking';
import { ChatContainer } from './Chat/ChatContainer';
import React, { Component } from 'react';
import { GarageInfo } from './GarageInfo';
import GarageFooter from './Footer/GarageFooter';

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
            return (    <div><nav id="topNavWrapper" className="no-js">
            <div className="title-bar top-nav-border t-navigation">
                <div className="column row menu-container">
                                <div className="title-bar-title">
                                    <img id="logoImg" accept="image/jpeg, image/png" alt={booking.garage.name} src="/images/quicklane/quicklaneLogo.png" className="garage-details-logo t-navigation__logo" /><h5 className="dark-text margin-l8 strong show-for-small-only t-navigation__name--mobile">{booking.garage.name}</h5>
                                </div>
    
                    <a href="#" className="gray-text show-for-small-only open-menu t-navigation__open-menu-icon--mobile"><i className="icon icon-2x icon-bars"></i></a>
                </div>
            </div>
        </nav>
    
        <div className="menu-overlay">
            <ul className="inner-menu">
                <li><a href="#" className="menu-link t-navigation__open-menu-link--mobile" data-for="#pageDetails">Booking Details</a></li>
                <li><a href="#" className="menu-link t-navigation__open-menu-link--mobile" data-for="#pageAbout">Contact Us</a></li>
                <li><a href="#" className="menu-link t-navigation__open-menu-link--mobile" data-for="#pageChat">Chat</a></li>
            </ul>
            <a className="close-menu t-navigation__close-menu-icon--mobile"><i className="icon icon-cross2 white"></i></a>
        </div>
    
    
        <div id="heroContainer">
    
            <div className="row hero" data-equalizer-watch>
                <BookingDetailsPanel booking={booking} />
                <ChatContainer booking={booking} />
                <GarageInfo booking={booking} />
            </div>
        </div>
        <div id="footerContainer">
            <GarageFooter booking={booking}/>
        </div>
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
