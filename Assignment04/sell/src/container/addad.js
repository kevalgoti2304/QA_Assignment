import React, {Component} from 'react'
import { connect } from 'react-redux'

//import required actions
import { addAd } from '../actions'

//import presentational component
import SellerForm from '../components/sellerform'

class AddAd extends Component{
    addAd(e){
        e.preventDefault();
        
        if(this.ad.isValid()){
            this.props.dispatch(
                addAd(this.ad.state)
            );
            let ads = JSON.parse(localStorage.getItem('ads')) || []
            let ad = {}
            Object.keys(this.ad.state).map(x=>{
                if (!x.includes("Error")) ad[x] = this.ad.state[x]
            })
            ads.push(ad);
            window.localStorage.setItem('ads', JSON.stringify(ads));
        }
        else console.log("Invalid");
    }
    render(){
        return (
        <SellerForm ref={(node) => {this.ad = node}} onSave={this.addAd.bind(this)}/>
        )
    }
} 

function mapStateToProps(state) {
    return {
    }
}
AddAd = connect(mapStateToProps)(AddAd)

export default AddAd
