import React, { Component } from 'react';
import DonutChart from 'react-donut-chart';
import GetTranslations from '../..//Resources/GetTranslations';
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
        let    strings = GetTranslations().SetLanguage(booking.language);
        
       function getStatusColour(status) {
            switch (status) {
            case 'Booked':
                statusConfig.label = strings.Label_Booked;
                statusConfig.statusGraphColour = "#c26565";
                break;
            case 'InProgress':
            case 'Paused':
            case 'Complete':
                statusConfig.label = strings.Label_InProgress;
                statusConfig.statusGraph = 200;
                statusConfig.statusGraphRemaining = 100;
                statusConfig.statusGraphColour = "#e79b51";
                break;
            case 'Closed':
            case 'FollowUp':
                statusConfig.label = strings.Label_Done;
                statusConfig.statusGraph = 300;
                statusConfig.statusGraphRemaining = 0;
                statusConfig.statusGraphColour = "#35a466";
                break;

            }
        };
        getStatusColour(booking.jobStatus);
       
        return (
            <li className="accordion-item booking-info is-active" data-accordion-item>
                <a href="#" className="accordion-title">{strings.JobDetails}</a>
                <div className="accordion-content" data-tab-content>
                <DonutChart height={200} width={200}  legend={false} colors={[statusConfig.statusGraphColour]} clickToggle={false}
    data={[{
        label:  statusConfig.label ,
        value: 25
    },
    {
        label: '',
        value: 75,
        isEmpty: true
    }]} />
                  
                    <div className="row ">
                        <div className="small-6 medium-12 column">
                            <div className="small-12 column">
                            {strings.Lounge_DateTimeIn}
                                </div>
                            <div className="small-12 column t-details__datetime-in">
                                <strong>   {booking.dateIn} </strong><br />
                                <strong>{booking.timeIn}</strong>
                                <div className="brl8"></div>
                            </div>
                        </div>
                        <div className="small-6 medium-12 column">
                            <div className="small-12 column">
                               {strings.Lounge_DueOut}
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

