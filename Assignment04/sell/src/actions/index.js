//action types
export const ADD_AD = 'ADD_AD'
export const KEYWORD_CHANGE = 'KEYWORD_CHANGE'

let nextAdID = 0;
// action creactors
export const addAd = ad => { 
  return {
    type: ADD_AD,
    id:nextAdID++,
    ad
  };
}

export const keywordChange = keyword => { 
  return {
    type: KEYWORD_CHANGE,
    keyword
  };
}