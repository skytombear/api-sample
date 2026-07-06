const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

const closePosition = async (body) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/order/close_position`;
  try {
    const res = await axios.post(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

// type: MARKET (close at market) or LIMIT (price mandatory).
// For HEDGE/ISOLATED positions, positionId is mandatory.
closePosition({
  symbol: 'BTC-PERP',
  type: 'MARKET',
  price: 0,
})
  .then(console.log)
  .catch(console.error);
