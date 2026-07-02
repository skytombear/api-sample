const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

// Bind take-profit / stop-loss to an existing position.
const bindTpSl = async (body) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/order/bind/tpsl`;
  try {
    const res = await axios.post(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

// Set takeProfitPrice and/or stopLossPrice (at least one is required).
bindTpSl({
  symbol: 'BTC-PERP',
  takeProfitPrice: 31000,
  takeProfitTrigger: 'markPrice',
  stopLossPrice: 22000,
  stopLossTrigger: 'lastPrice',
})
  .then(console.log)
  .catch(console.error);
