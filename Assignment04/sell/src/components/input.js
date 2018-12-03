import React, { Component } from 'react';
import PropTypes from 'prop-types';

import '../styles/input.less'

class Input extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div className="form-field">
              <label> {this.props.fieldName} </label>
              <input 
                type="text" 
                name={this.props.name}
                required={this.props.required}
                className={this.props.error && "invalid-input"}
                size={this.props.size}
                placeholder={this.props.placeholder}
                onChange = {this.props.onChange}
                />
              {
                  this.props.error && 
              <span className="field-error">*{this.props.error}</span>
              }
            </div>
        );
    }
}

Input.propTypes = {
    fieldName: PropTypes.string.isRequired,
    size: PropTypes.number,
    error: PropTypes.string,
    placeholder: PropTypes.string,
}

export default Input;