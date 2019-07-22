import React, { Component } from 'react';
import GetTranslations from '../..//Resources/GetTranslations';
export default class CommunicationItem extends React.Component {
   strings = GetTranslations().SetLanguage(this.props.language);
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
                    <strong>{this.strings.Bookd_Website_Label}</strong><br />
                    <a href={address} target="_blank">{props.value}</a>
                </p>
                break;
                case "Email":
                      
                       return     <p>
                            <strong>{this.strings.Bookd_Email_Label}</strong><br />
                            <a href={'mailto:' +props.value} target="_blank">{props.value}</a>
                        </p>
                        break;
                        case "Telephone":
                      
                                return     <p>
                                     <strong>{this.strings.Bookd_Telephone_Label}</strong><br />
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