import React, { Component } from 'react';
import PropTypes from 'prop-types';

import Input from './input';

import '../styles/button.less'
import { error } from 'util';

class SellerForm extends Component {
    constructor(props) {
        super(props);
        this.state = this.getInitState();
        this.handleChange = this.handleChange.bind(this);
        this.isValid = this.isValid.bind(this);
    }
    
    getInitState(){
        return {
            sellerName:"",
            address:"",
            city:"",
            phoneNumber:"",
            email:"",
            manufacturer:"",
            model:"",
            year:"",
            sellerNameError:"",
            addressError:"",
            cityError:"",
            phoneNumberError:"",
            emailError:"",
            manufacturerError:"",
            modelError:"",
            yearError:""
        }
    }
    isValid(){
        let valid = true;
        Object.keys(this.state).map(element => {
            
            if(this.state[element]==="" && !element.includes("Error")) {                
                this.setState({[element+"Error"]:"Required"})
                valid = false
            }
            else{
                this.setState({[element+"Error"]:null})
            }
        });
        if(this.state.phoneNumber.length > 0 && !this.state.phoneNumber.match(`^[(]{0,1}[0-9]{3}[)]{0,1}-{0,1}[0-9]{3}-[0-9]{4}$`)){
            this.setState({phoneNumberError:"Invalid phone number"}) 
            valid = false
        }
                
        return valid;
    }
    handleChange(event) {        
        this.setState({[event.target.name]: event.target.value});
    }
    render() {
                
        return (
            <div className="content">
                <div className="box">
                    <Input
                        ref={(node) => {this.sellerName = node}}
                        onChange={this.handleChange}
                        fieldName="Seller Name"
                        size={50}
                        placeholder="Odin"
                        name="sellerName"
                        error = {this.state.sellerNameError}
                    />
                    <Input
                    ref={(node) => {this.address = node}}
                    fieldName="Address"
                    size={50}
                    onChange={this.handleChange}
                    placeholder="111, Main Street"
                    name="address"
                    required={true}
                    error = {this.state.addressError || null}
                    />
                    <Input
                    ref={(node) => {this.city = node}}
                    fieldName="City"
                    size={50}
                    onChange={this.handleChange}
                    placeholder="Asgard"
                    name="city"
                    required={true}
                    error = {this.state.cityError || null}
                    />
                    <Input
                    ref={(node) => {this.phoneNumber = node}}
                    fieldName="Phone number"
                    size={50}
                    onChange={this.handleChange}
                    placeholder="XXX-XXX-XXXX, or (XXX)XXX-XXXX"
                    name="phoneNumber"
                    required={true}
                    error = {this.state.phoneNumberError || null}
                    />
                    <Input
                    ref={(node) => {this.email = node}}
                    fieldName="Email"
                    size={50}
                    onChange={this.handleChange}
                    placeholder="odin@asgard.god"
                    name="email"
                    required={true}
                    error = {this.state.emailError || null}
                    />
                    <Input
                    ref={(node) => {this.manufacturer = node}}
                    fieldName="Manufacturer"
                    size={50}
                    onChange={this.handleChange}
                    placeholder="Maruti Suzuki"
                    name="manufacturer"
                    required={true}
                    error = {this.state.manufacturerError || null}
                    />
                    <Input
                    ref={(node) => {this.model = node}}
                    fieldName="Model"
                    size={50}
                    onChange={this.handleChange}
                    placeholder="Swift Desire"
                    name="model"
                    required={true}
                    error = {this.state.modelError || null}
                    />
                    <Input
                    ref={(node) => {this.year = node}}
                    fieldName="Year"
                    size={50}
                    onChange={this.handleChange}
                    placeholder="2018"
                    name="year"
                    required={true}
                    error = {this.state.yearError || null}
                    />
                    <button className="button-save" onClick={this.props.onSave}>
                        SAVE
                    </button>  
                </div>
            </div>
        );
    }
}

export default SellerForm;