import { combineReducers } from 'redux'
import ads from './ads'
import keyword from './keyword';

const adApp = combineReducers({
  ads,
  keyword
})
 
export default adApp