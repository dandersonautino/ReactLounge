﻿import React, { Component } from 'react';
import CommunicationItem from './CommunicationItem';
import TermsAndNumbers from './TermsAndNumbers';
export default class GarageFooter extends React.Component {
    constructor() {
    super();
    this.state = {  language: 'en'};

  
}

    render(){
        let { booking } = this.props;
        return  (
        <div className="row">

    <div className="medium-3 column">  
    {booking.garageCommunications.map((comm, i) => {
            return (<CommunicationItem key={i} comms={comm} language={booking.language} />) })}
    </div>

    <div className="medium-4 column">
        opening hours
        </div>
        <div className="medium-3 column">
            Facillities
            </div>
            <div className="medium-2 column">
                <TermsAndNumbers language={this.state.language}  booking={booking}/>
                </div>
        </div>
     
        );
  
    }
}