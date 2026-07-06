const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

const setLeverage = async (body) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/leverage`;
  try {
    const res = await axios.post(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

// leverage: 0 means cross margin.
setLeverage({
  symbol: 'BTC-PERP',
  leverage: 0,
})
  .then(console.log)
  .catch(console.error);
