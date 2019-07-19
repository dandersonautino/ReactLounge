import React, { Component } from 'react';


import { Booking } from './components/Booking/Booking';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
    <Booking />
    );
  }
}
