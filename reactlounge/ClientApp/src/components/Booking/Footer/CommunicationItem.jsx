import React, { Component } from 'react';
export default class CommunicationItem extends React.Component {
    FormatItem(props) {
        if (!props.value || props.value === "")
        {
            return;
        }
        switch  (props.contactMethodType)
        {
            case "Website":
                var address=props.value.includes("http") ?props.value :  "http://" +props.value 
               return     <p>
                    <strong>Website</strong><br />
                    <a href={address} target="_blank">{props.value}</a>
                </p>
                break;
                case "Email":
                      
                       return     <p>
                            <strong>Email</strong><br />
                            <a href={'mailto:' +props.value} target="_blank">{props.value}</a>
                        </p>
                        break;
                        case "Telephone":
                      
                                return     <p>
                                     <strong>Telephone</strong><br />
                                     {props.value}
                                 </p>
                                 break;
                                 default:
                                     return props.value;
                                     break;
        }
    
 };
    render(){
        let { comms } = this.props;
     
        return  (
       
     <div>{this.FormatItem(comms)}</div>
        );
  
    }
}