import React, { Component } from 'react';
import GoogleMapReact from 'google-map-react';

const MapMarkerImage= ({ text }) =>  <img width="25" src='/Images/mapmarker.png'/>;
class SimpleMap extends Component {
    static defaultProps = {
      center: {
        lat: 59.95,
        lng: 30.33
      },
      zoom: 15
    };
   
    render() { 
         let contents = this.props
      return (
        // Important! Always set the container height explicitly
        <div style={{ height: '50vh', width: '100%' }}>
          <GoogleMapReact
            bootstrapURLKeys={{ key: "AIzaSyA-_fIN-X2MKvFnndTYF2_-cVpptKMoNYI" }}
            defaultCenter={this.props.center}
            defaultZoom={this.props.zoom}
          >
            <MapMarkerImage
              lat={this.props.center.lat}
              lng={this.props.center.lng}
            
            />
          </GoogleMapReact>
        </div>
      );
    }
  }


export default SimpleMap;