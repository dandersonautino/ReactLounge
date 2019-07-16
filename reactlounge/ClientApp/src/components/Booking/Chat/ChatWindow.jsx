import React, { Component } from 'react';
import {HubConnectionBuilder } from '@aspnet/signalr';
export default class ChatWindow extends Component {
    constructor(props) {
        super(props);
        
        this.state = {
          nick: '',
          message: '',
          messages: [],
          hubConnection: null,
        };
      }
      componentDidMount = () => { 
          
        let hubConnection = new HubConnectionBuilder()
        .withUrl("https://api-local.autinoconnect.com/signalr")
        .build();
     
    

        const nick = window.prompt("Your name:", "John");
    
   
    
        this.setState({ hubConnection, nick }, () => {
          this.state.hubConnection
            .start()
            .then(() => console.log('Connection started!'))
            .catch(err => console.log('Error while establishing connection :('));
    
          this.state.hubConnection.on('sendToAll', (nick, receivedMessage) => {
            const text = "${nick}: ${receivedMessage}";
            const messages = this.state.messages.concat([text]);
            this.setState({ messages });
          });
        }); 
      }
      render() {
        return <div>Here goes chat</div>;
      }
    }

