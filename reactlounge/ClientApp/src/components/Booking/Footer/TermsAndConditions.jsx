import React, { Component } from 'react';
import Modal from 'react-modal';

import GetTranslations from '../../Resources/GetTranslations';
Modal.setAppElement('#root')
export default class TermsAndConditions extends React.Component { 
  constructor() {
    super();
 
    this.state = {
      modalIsOpen: false
    };
 
    this.openModal = this.openModal.bind(this);

    this.closeModal = this.closeModal.bind(this);
  }
  
  openModal() {
    this.setState({modalIsOpen: true});
  }
 
 
 
  closeModal() {
    this.setState({modalIsOpen: false});
  }

  
    render(){ 
       
      const customStyles = {
        content : {
          top                   : '50%',
          left                  : '50%',
          right                 : 'auto',
          bottom                : 'auto',
          marginRight           : '-50%',
          transform             : 'translate(-50%, -50%)'
        }
      };
   
        let terms=this.props.termsAndConditions;
        let    strings = GetTranslations().SetLanguage(this.props.language);
       
    
return (

  
    <p>
        <strong>
            <a data-open="TermsModal" onClick={this.openModal}>{strings.TermsAndConditions} </a> 
            </strong> <br/>
            <Modal
          isOpen={this.state.modalIsOpen}
          onAfterOpen={this.afterOpenModal}
          onRequestClose={this.closeModal}
          style={customStyles}
          contentLabel={strings.TermsAndConditions}
        >
 
          <h2 >{strings.TermsAndConditions}</h2>
          
          <div>{terms}</div>
          <button onClick={this.closeModal}>{strings.Lounge_Close}</button>
        </Modal>
        
    </p>

)
    }
}