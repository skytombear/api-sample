const axios = require('axios');
const { SPOT_API_VERSION } = require('../utils/constants');
const { getSpotUrl, getAuthHeaders } = require('../utils/common');

const queryOrder = async (params) => {
  const endpoint = `/api/${SPOT_API_VERSION}/order`;
  try {
    const res = await axios.get(getSpotUrl(endpoint), {
      headers: getAuthHeaders(endpoint),
      params,
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

// Query a single order by orderID (or use clOrderID). One is mandatory.
queryOrder({
  orderID: 'your-order-id',
})
  .then(console.log)
  .catch(console.error);
