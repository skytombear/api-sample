const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

// Dead man's switch: cancel all orders after `timeout` ms. Send timeout=0 to disable.
const cancelAllAfter = async (body) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/order/cancelAllAfter`;
  try {
    const res = await axios.post(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

cancelAllAfter({
  timeout: 60000,
})
  .then(console.log)
  .catch(console.error);
