import React, { Component } from 'react';


export class GarageInfo extends React.Component {

    render() {
        let { booking } = this.props;
        var mapLink = '';
      
        var directionsLink = '';

        function FieldWithBreak(field) {
            return <div> {field} <br /></div>
        }

        if (booking.garage.postCode) {
            mapLink = <a href={"https://www.google.co.uk/maps/search/" + booking.garage.postCode + "/"} target="_blank"><div id="map" class="t-map base-colour "></div></a>
            directionsLink = <p> <a href={"https://www.google.co.uk/maps/search/" + booking.garage.postCode + "/"} target="_blank" class="t-map__link">Get directions &raquo;</a> </p> 
        }
       var addressFields =[];
        if (booking.garage.address1) {
            addressFields.push({field: booking.garage.address1} );

        }
        if (booking.garage.address2) {
            addressFields.push({ field: booking.garage.address2 });
        }
        if (booking.garage.address3) {
            addressFields.push({ field: booking.garage.address3 });
        }
        if (booking.garage.address4) {
            addressFields.push({ field: booking.garage.address4 });
        }
        if (booking.garage.postCode) {
            addressFields.push({ field: booking.garage.postCode });
        }
//this.state.address = addressFields;
        return (
          <div class="small-12 medium-3 column mobile-page hide-for-small-only" id="pageAbout">
            <ul class="accordion" data-accordion data-allow-all-closed="true" data-multi-expand="true">
                <li class="accordion-item is-active" data-accordion-item>
                    <a href="#" class="accordion-title">How to find us</a>
                        <div class="accordion-content padding-none" data-tab-content>
                                {mapLink}
        
        <div id="map-address">
                            <p>
                                    <strong> {booking.garage.name} </strong><br />
    
   
                                    <div>  {addressFields.map((item, key) =>
<span>{item.field}<br/></span>
)}</div>
                            </p>
    {directionsLink}
                        </div>
                    </div>
                </li>
            </ul>
        
            <a class="chat-bubble show-for-small-only t-chat-button" data-for="#pageChat"><i class="icon icon-2x icon-messages white"></i><span class="white">Chat</span></a>
        </div>
        );
    }
}
