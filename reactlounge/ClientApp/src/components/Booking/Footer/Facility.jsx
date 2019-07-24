import React, { Component } from 'react';
export default class Facility extends React.Component {
    render() {
       
        return (
        <div className="row ">
            <div className="small-12 column">{this.props.name} </div>
        </div>
);
}
}
