﻿declare var require: any
var React = require('react');
export class Repair extends React.Component {
    render() {
        let { repair } = this.props;
        return (
        <div className="row ">
            <div className="small-12 column">{repair.name} </div>
        </div>
);
}
}
