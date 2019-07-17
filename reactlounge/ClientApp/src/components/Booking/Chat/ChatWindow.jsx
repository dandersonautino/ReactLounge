import React, { Component } from 'react';
import {HubConnectionBuilder } from '@aspnet/signalr';
import ChatMessage from './ChatMessage';
export default class ChatWindow extends Component {
    constructor(props) {
        super(props);
        
        this.state = {
          chatToken:props.ChatToken,
          messages: [],
          hubConnection: null, 
          loading : true
        };
       
      }
      componentDidMount = () => { 
        var url =process.env.REACT_APP_API_PREFIX+'/api/chat?authhash='+ encodeURIComponent(this.state.chatToken);
        fetch(url)
        .then(response => response.json())
        .then(data => {
            this.setState({ messages: data.messages, loading: false });
        });
        // let hubConnection = new HubConnectionBuilder()
        // .withUrl(process.env.REACT_APP_API_PREFIX)
        // .build();
     
    

        // const nick = window.prompt("Your name:", "John");
    
   
    
        // this.setState({ hubConnection, nick }, () => {
        //   this.state.hubConnection
        //     .start()
        //     .then(() => console.log('Connection started!'))
        //     .catch(err => console.log('Error while establishing connection :('));
    
        //   this.state.hubConnection.on('sendToAll', (nick, receivedMessage) => {
        //     const text = nick +":" +receivedMessage;
        //     const messages = this.state.messages.concat([text]);
        //     this.setState({ messages });
        //   });
        // }); 
      } 
     
    
      render() {
        const messages = this.state.messages.map((message , index)=> <ChatMessage key={index} message={message}/>);
        const text =this.state.loading ?     <div className="loader"></div> :  <div className="chat-messages">{messages}</div>
        return (
          <div>
        {text}
        </div>)
      }
    }

