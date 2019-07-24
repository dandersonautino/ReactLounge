import React, { Component } from 'react';
import CommunicationItem from './CommunicationItem';
import TermsAndNumbers from './TermsAndNumbers';
import LocalizedStrings from 'react-localization';
import Facility from './Facility';
import GetTranslations from '../..//Resources/GetTranslations';
export default class GarageFooter extends React.Component {
    constructor() {
    super();
 
  
}

    render(){
        let { booking } = this.props;
        let    strings = GetTranslations().SetLanguage(booking.language);
        let facility= booking.facilities.length>0 &&    <React.Fragment>
        <strong>{strings.Bookd_Facilities_Label}</strong> <br />
        {booking.facilities.map((facility, i) => {
return (<Facility key={i} name={facility} />)
})}
    </React.Fragment>
        return  (
        <div className="row">
    <div className="medium-3 column">  
    {booking.garageCommunications.map((comm, i) => {
            return (<CommunicationItem key={i} comms={comm} language={booking.language} />) })}
    </div>

    <div className="medium-4 column">
    <div id="row collapse">
            <div className="medium-12 column padding-none">
                <p className="margin-none"><strong>{strings.Bookd_OpeningHours_Label}</strong></p>
                {booking.openingHours}
            </div>
        </div>   
        </div>
        <div className="medium-3 column">
     {facility}
            </div>
            <div className="medium-2 column">
                <TermsAndNumbers language={booking.language}  booking={booking}/>
                </div>
        </div>
     
        );
  
    }
}