import React, { Component } from 'react';
import PropTypes from 'prop-types';

import '../styles/adlist.less'
class AdList extends Component {
    constructor(props) {
        super(props);
        this.searchChange = this.searchChange.bind(this);
    }

    searchChange(event){
        this.props.keywordChange(event.target.value);
    }

    render() {     
        let {ads} = this.props;
        
        
        return (
            <div>
                <div className="wrapper">
                    <input className="search" onChange={this.searchChange} size="50" placeholder="Search"/>                
                </div>
                <div className="info-container">
                {
                    ads.map(element=>{
                        return <div className="seller-info" key={`${element.adID}`}>
                        <div className="seller-name"> 
                            {element.sellerName}
                        </div>
                        <div className="attribute"> {element.address}</div>
                        <div className="attribute"> {element.city}</div>
                        <div className="attribute"> {element.phoneNumber}</div>
                        <div className="attribute"> {element.email}</div>
                        <div className="attribute"> {element.manufacturer}</div>
                        <div className="attribute"> {element.model}</div>
                        <div className="attribute"> {element.year}</div>
                        <a target="new_window" href={`http://www.jdpower.com/cars/${element.manufacturer}/${element.model}/${element.year}`} className="attribute">Visit Site</a>
                    </div>
                    })
                }
                </div>
            </div>
        );
    }
}

AdList.propTypes = {

};

export default AdList;