import React, { Component } from 'react';
import PropTypes from 'prop-types';

import '../styles/header.less'
class Header extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div className="title">
                <div className="logo">
                    Vehicle Seller
                </div>
                <div className="moto">
                    Buy or Sell - always get the very Best
                </div>
            </div>
        );
    }
}

Header.propTypes = {

};

export default Header;