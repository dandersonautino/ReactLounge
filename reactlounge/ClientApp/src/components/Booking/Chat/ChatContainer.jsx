import React, { Component } from 'react';

import {HubConnectionBuilder } from '@aspnet/signalr';
import ChatMessage from './ChatMessage';
export class ChatContainer  extends React.Component {constructor(props) {
    super(props);
    
    this.state = {
      chatToken:props.booking.chatToken,
      messages: [],
      hubConnection: null, 
      loading : true,
      message : '',
      canSend : true
    };
    this.handleFormMessage = this.handleFormMessage.bind(this);
    this.sendChat= this.sendChat.bind(this);
  }
  handleFormMessage(event)
  {
    const {name,value} = event.target;
    this.setState({
      [name]:value
    });
 
  }
  sendChat(event)
  {
    event.preventDefault();
    this.setState({ canSend: false})
    var url = new URL(process.env.REACT_APP_API_PREFIX+'/api/chat/ChatSend')
    this.state.hubConnection
    .invoke('Send',this.props.booking.contact.firstName, this.props.booking.contact.lastName, this.state.message, this.state.chatToken, 3, this.props.booking.utcOffset)
    .catch(err => console.error(err));
    var params = {authhash:this.state.chatToken, message :this.state.message} 
    
    url.search = new URLSearchParams(params)
    
    fetch(url)
    .then(response => console.log('Success:'))
    .catch(error => console.error('Error:', error));
this.setState({ canSend: true, message:''});
  }
  componentDidMount = () => { 
    var url =process.env.REACT_APP_API_PREFIX+'/api/chat?authhash='+ encodeURIComponent(this.state.chatToken);
    fetch(url)
    .then(response => response.json())
    .then(data => {
        this.setState({ messages: data.messages, loading: false });
    });
    var sigUrl=process.env.REACT_APP_SIGNALR_HUB;
    let hubConnection = new HubConnectionBuilder()
    .withUrl(sigUrl)
    .build();

    this.setState({ hubConnection }, () => {
      this.state.hubConnection
        .start()
        .then(() => {console.log('Connection started!');  hubConnection.send("joinGroup", this.state.chatToken)})
        .catch(err => console.log('Error while establishing connection :('));
       
      this.state.hubConnection.on('broadcastMessage', ( receivedMessage) => {
      
        const updatedMessages= this.state.messages.concat(JSON.parse(receivedMessage));
        this.setState({ messages:updatedMessages });
      });
    }); 
  ; 
  } 
    render() {
        let { booking } = this.props; 
        const messages = this.state.messages.map((message , index)=> <ChatMessage key={index} message={message}/>);
        const chatMessageArea =this.state.loading ?     <div className="loader"></div> :  <div className="chat-messages">{messages}</div>
       
        var opts = {};
        if (this.state.loading || !this.state.canSend) {
            opts['disabled'] = 'disabled';
        }
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
            {chatMessageArea}
            </div>
            <a className="scroll-down show-for-small-only t-scroll-down" hidden><i className="icon icon-angle-down"></i></a>
            </div>
           <form onSubmit={this.sendChat}>
             <fieldset {...opts}>
            <div className="small-10 medium-9 column">
            <textarea className="autosize" cols="20" data-val="true" data-val-required="Message is required" id="js-chat-area" value={this.state.message} name="message" onChange={this.handleFormMessage} placeholder="Type message here..." rows="2" />
            <span className="hide-for-small-only"><span className="field-validation-valid" data-valmsg-for="Message" data-valmsg-replace="true"></span></span>
            <div id="js-error" className="error-message" style={{display: "none"}}></div>
            </div>
            <div className="small-2 medium-3 column">
            <button id="js-send-message" className="button userDefined send-button t-chat-footer__send">
            <span className="hide-for-small-only">Send</span>
            <span className="show-for-small-only icon-wrap t-chat-footer__plane"><i className="icon icon-1-5x icon-paperplane-dark"></i></span>
            </button>
            </div>
            </fieldset>
            </form>
            <footer className="t-chat-footer">
            <div className="row collapse comm-box-edit">
        
            </div>
            </footer>  
            </section>
                </div>
            </div>
);
}
}
