import React, {Component} from 'react';

import Header from './header'
import AddAd from "../container/addad"
import VisibleAdList from "../container/visibleadlist"

import '../styles/master.less'

export default class App extends Component {
  render(){
    return (
      <div>
        <Header />
        <div className="main-wrapper">
          <AddAd />
          <VisibleAdList />
        </div>
      </div>
    )
  }
}
