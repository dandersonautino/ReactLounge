import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { Booking } from './components/Booking/Booking';
import { BookingDetailsPanel } from './components/Booking/BookingDetailsPanel';
export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
            <Route path='/fetch-data' component={FetchData} />
          <Route path='/booking' component={Booking} />
      </Layout>
    );
  }
}
