const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

const queryOrder = async (params) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/order`;
  try {
    const res = await axios.get(getFuturesUrl(endpoint), {
      params,
      headers: getAuthHeaders(endpoint),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

// Query by orderID (or use clOrderID). One of them is mandatory.
queryOrder({
  orderID: 'your-order-id',
})
  .then(console.log)
  .catch(console.error);
