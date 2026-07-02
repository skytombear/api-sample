const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl } = require('../utils/common');

// Public: default market risk-limit settings per market and risk level.
// Omit `symbol` to retrieve all markets.
const getMarketRiskLimit = async (params) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/market/risk_limit`;
  try {
    const res = await axios.get(getFuturesUrl(endpoint), {
      params,
    });
    return res.data;
  } catch (error) {
    return error;
  }
};

getMarketRiskLimit({
  symbol: 'BTC-PERP',
})
  .then(console.log)
  .catch(console.error);
