import React, { Component } from 'react';
import Geocode from "react-geocode";
import GoogleMapReact from 'google-map-react';
import { Container, Image } from 'semantic-ui-react'
import SimpleMap from './SimpleMap';
const AnyReactComponent = ({ text }) => (<div>{text}</div>);
export class GarageInfo extends React.Component {constructor(props){
    super(props);
    this.state ={coord : {
        center: {
          lat:  0,
          lng: 0
        },
        zoom: 11
    },geoLocationSuccess : false};
  }
    directionsLink = '';
    googleApiKey="AIzaSyA-_fIN-X2MKvFnndTYF2_-cVpptKMoNYI";
    componentDidMount() {
     
        this.mapSection(this.props.booking.garage.postCode);
      }
    async mapSection(postCode)
    { if (postCode)
        {
       let  foundLat: number;
       let  foundLong: number;
         Geocode.setApiKey(this.googleApiKey);
        await  Geocode.fromAddress(postCode).then(
            response => {
              const { lat, lng } = response.results[0].geometry.location;
              foundLat=lat;
              foundLong= lng;
              console.log(lat, lng);
            },
            error => {
              console.error(error);
            }
          ); 
          this.setState({coord : {
            center: {
              lat:  foundLat,
              lng: foundLong
            },
            zoom: 11
          },
            geoLocationSuccess : true})
      
         
        }
        
    }
    render() {
        
        let { booking } = this.props;
       
      if (booking.garage.postCode)
      {
        this.directionsLink = <p> <a href={"https://www.google.co.uk/maps/search/" + booking.garage.postCode + "/"} target="_blank" className="t-map__link">Get directions &raquo;</a> </p> 
      }
       
    
        function FieldWithBreak(field) {
            return <div> {field} <br /></div>
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
          <div className="small-12 medium-3 column mobile-page hide-for-small-only" id="pageAbout">
            <ul className="accordion" data-accordion data-allow-all-closed="true" data-multi-expand="true">
                <li className="accordion-item is-active" data-accordion-item>
                    <a href="#" className="accordion-title">How to find us</a>
                        <div className="accordion-content padding-none" data-tab-content>
                        {this.state.geoLocationSuccess && <SimpleMap center={this.state.coord.center}/>}
        
        <div id="map-address">
                            <p>
                                    <strong> {booking.garage.name} </strong><br />
    
   
                                    <div>  {addressFields.map((item, key) =>
<span>{item.field}<br/></span>
)}</div>
                            </p>
    {this.directionsLink}
                        </div>
                    </div>
                </li>
            </ul>
        
            <a className="chat-bubble show-for-small-only t-chat-button" data-for="#pageChat"><i className="icon icon-2x icon-messages white"></i><span className="white">Chat</span></a>
        </div>
        );
    }
}
