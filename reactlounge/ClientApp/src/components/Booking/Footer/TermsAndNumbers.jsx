import React, { Component,useState } from 'react';
// import {Button,Modal} from 'react-bootstrap';

export default class TermsAndNumbers extends React.Component { 
  
    render(){ 
       
    //    const [show, setShow] = useState(false);

   // const handleClose = () => setShow(false);
    //const handleShow = () => setShow(true);
        let booking=this.props.booking;
        let companyNumber =booking.companyNumber && booking.companyNumber!=="" &&   <p>
        <strong>Company number</strong> <br />
        {booking.companyNumber }</p>
        let vatNumber =booking.vatNumber && booking.vatNumber!=="" &&   <p>
        <strong>Tax number</strong> <br />
        {booking.vatNumber }</p>
    //     let tandC = booking.showTermsAndConditions && <p>
    //     <strong>
    //         <a data-open="TermsModal">View Terms and Conditions &amp; Privacy Policy </a> 
           
    //     </strong> <br/>
    // </p>
    
return (
<div>
    {vatNumber}
    {companyNumber}
    {/* {tandC} */}
</div>
)
    }
}