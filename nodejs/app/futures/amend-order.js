const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

const amendOrder = async (body) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/order`;
  try {
    const res = await axios.put(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

// type: PRICE | SIZE | TRIGGERPRICE | ALL. `value` applies to the given type.
amendOrder({
  symbol: 'BTC-PERP',
  orderID: 'your-order-id',
  type: 'PRICE',
  value: 22000,
})
  .then(console.log)
  .catch(console.error);
