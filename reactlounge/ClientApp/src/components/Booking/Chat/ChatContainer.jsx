import React, { Component } from 'react';
import ChatWindow from './ChatWindow';
export class ChatContainer  extends React.Component {
    render() {
        let { booking } = this.props;
        return (
        <div className="small-12 medium-6 column mobile-page" id="pageChat">
            <div className="panel-comms">
                    <header className="clearfix hide-for-small-only"> </header>
            <section id="commsContainer" className="t-comms-area">
       
            <div id="commsFeed">
            <div className="welcome hide-for-small-only t-banner">
                                <h1 className="t-banner__hello"> {booking.contact.firstName} </h1>
            <h2 className="t-banner__welcome">Welcome to your booking</h2>

        
        </div>
            <div id="commsFeedMessages">
     <ChatWindow />
            </div>
            <a className="scroll-down show-for-small-only t-scroll-down" hidden><i className="icon icon-angle-down"></i></a>
            </div>

         
            </section><footer className="t-chat-footer">
            <div className="row collapse comm-box-edit">
            <div className="small-10 medium-9 column">
            <textarea className="autosize" cols="20" data-val="true" data-val-required="Message is required" id="js-chat-area" name="Message" placeholder="Type message here..." rows="2"></textarea>
            <span className="hide-for-small-only"><span className="field-validation-valid" data-valmsg-for="Message" data-valmsg-replace="true"></span></span>
            <div id="js-error" className="error-message" style={{display: "none"}}></div>
            </div>
            <div className="small-2 medium-3 column">
            <button id="js-send-message" className="button userDefined send-button t-chat-footer__send">
            <span className="hide-for-small-only">Send</span>
            <span className="show-for-small-only icon-wrap t-chat-footer__plane"><i className="icon icon-1-5x icon-paperplane-dark"></i></span>
            </button>
            </div>
            </div>
            </footer>
                </div>
            </div>
);
}
}
