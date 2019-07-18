import React, { Component } from 'react';

export default class ChatMessage extends React.Component {
    
    
    render() {
        let message = this.props.message;
    function getClass(value)
    { switch (value) {
        case 1:
            return 'garage';
        case 2:
                return 'garage';
        case 3:
                return 'client';
        case 4:
                return 'garage';
            default:
                return 'garage';
        }}
        const MessageClass =getClass(message.messageTypeId);
        return <div className={'comm-box ' + MessageClass}>        
        <div className={'comm-box-icon hide-for-small-only t-user-icon--'+MessageClass}>
            <i className="icon icon-user icon-1-5x"></i>
        </div>
        <div className={'comm-box-detail t-bubble--' + MessageClass}>
            {message.message}
        </div>   
        <div className="row-break"></div>
        <div className={'comm-box-date ' + MessageClass}>
            {message.displayDate}
        </div>
    </div>
       }
}