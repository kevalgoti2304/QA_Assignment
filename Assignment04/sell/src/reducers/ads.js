const ads = (state = [], action) => {
  let id = 0;
  state=JSON.parse(localStorage.getItem('ads')) || []
  console.log(state);
  
  switch (action.type) {
    case 'ADD_AD':
      return [
        {
          adID: action.id,
          sellerName: action.ad.sellerName,
          address: action.ad.address,
          city: action.ad.city,
          phoneNumber: action.ad.phoneNumber,
          email: action.ad.email,
          manufacturer: action.ad.manufacturer,
          model: action.ad.model,
          year: action.ad.year,
        },
        ...state
      ]
    default:
      return state
  }
  window.localStorage.setItem('ads', state);
}
 
export default ads
