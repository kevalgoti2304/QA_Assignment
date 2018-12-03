import React, {Component} from 'react'
import { connect } from 'react-redux'

//import required actions
import { keywordChange } from '../actions'

//import presentational component
import AdList from '../components/adlist'

const getFilteredAds = (ads, keyword) => {
  return ads.filter(ad=>{        
        let matches = false;
        Object.keys(ad).map((key)=>{       
          if(ad[key].toString().includes(keyword)){
            matches = true;
            return;
          }
        })
        return matches;
    })
}

class VisibleAdList extends Component{
  render(){
    return (
      <AdList {...this.props}/>
    )
  }
}

function mapStateToProps(state) {
  return {
    ads: getFilteredAds(state.ads, state.keyword)
  }
}

function mapDispatchToProps (dispatch) {
  return {
    keywordChange: (payload) =>{
      dispatch(keywordChange(payload))
    }
  }
}

VisibleAdList = connect(
  mapStateToProps,
  mapDispatchToProps
)(VisibleAdList)
 
export default VisibleAdList
