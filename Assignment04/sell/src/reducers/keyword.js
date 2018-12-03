const keyword = (state = "", action) => {
    switch (action.type) {
      case 'KEYWORD_CHANGE':
        return action.keyword
      default:
        return state
    }
  }
   
export default keyword