import React, { Component,useState } from 'react';
import TermsAndConditions from './TermsAndConditions';
import { data } from '../../Resources/Resources'
import LocalizedStrings from 'react-localization';
import GetTranslations from '../..//Resources/GetTranslations';
export default class TermsAndNumbers extends React.Component { 
  constructor() {
    super();
   

  
}    

    render(){ 
        let booking=this.props.booking;
  let    strings = GetTranslations().SetLanguage(booking.language);
      
   
        
        let companyNumber =booking.companyNumber && booking.companyNumber!=="" &&   <p>
        <strong>{strings.Label_CompanyNumber}</strong> <br />
        {booking.companyNumber }</p>
        let vatNumber =booking.vatNumber && booking.vatNumber!=="" &&   <p>
        <strong>{strings.Label_TaxNumber}</strong> <br />
        {booking.vatNumber }</p>
        let tandC = booking.showTermsAndConditions && <TermsAndConditions language={booking.language} termsAndConditions={booking.termsAndConditions} />
    
return (
<div>
    {vatNumber}
    {companyNumber}
    {tandC}
</div>
)
    }
}