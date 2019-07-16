import React, { Component } from 'react';
let statusConfig =
{
    label: 'Booked',
    statusGraph: "100",
    statusGraphRemaining: "200",
    statusGraphColour: "#4375C1"
}
export class BookingInfo extends React.Component {
  



    render() {
        let { booking } = this.props;
       function getStatusColour(status) {
            switch (status) {
            case 'Booked':
                statusConfig.label = 'Booked';
                statusConfig.statusGraphColour = "#c26565";
                break;
            case 'InProgress':
            case 'Paused':
            case 'Complete':
                statusConfig.label = 'In Progress';
                statusConfig.statusGraph = 200;
                statusConfig.statusGraphRemaining = 100;
                statusConfig.statusGraphColour = "#e79b51";
                break;
            case 'Closed':
            case 'FollowUp':
                statusConfig.label = 'Done';
                statusConfig.statusGraph = 300;
                statusConfig.statusGraphRemaining = 0;
                statusConfig.statusGraphColour = "#35a466";
                break;

            }
        };
        getStatusColour(booking.jobStatus);

        return (
            <li className="accordion-item booking-info is-active" data-accordion-item>
                <a href="#" className="accordion-title">JobDetails</a>
                <div className="accordion-content" data-tab-content>

                    <div id="doughnutChart" className="chart">
                        <div className="chartText">
                            <i className="icon icon-calendar icon-2x"></i>                       
                            <span> { statusConfig.label } </span>
                        </div>
                    </div>
                    <div className="row ">
                        <div className="small-6 medium-12 column">
                            <div className="small-12 column">
                              Due In
                                </div>
                            <div className="small-12 column t-details__datetime-in">
                                <strong>   {booking.dateIn} </strong><br />
                                <strong>{booking.timeIn}</strong>
                                <div className="brl8"></div>
                            </div>
                        </div>
                        <div className="small-6 medium-12 column">
                            <div className="small-12 column">
                               Due out
                                </div>
                            <div className="small-12 column t-details__datetime-out">
                                <strong> {booking.dateOut} </strong><br />
                                <strong> {booking.timeOut}</strong>
                            </div>
                        </div>
                    </div>
                </div>
            </li>
    );
}
}

