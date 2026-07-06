const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

const createAlgoOrder = async (body) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/order/peg`;
  try {
    const res = await axios.post(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

createAlgoOrder({
  symbol: 'BTC-PERP',
  price: 21500,
  size: 1,
  side: 'BUY',
  clOrderID: 'test-algo-order',
  stealth: 10,
  deviation: -10,
})
  .then(console.log)
  .catch(console.error);
