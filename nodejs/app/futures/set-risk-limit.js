const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

const setRiskLimit = async (body) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/risk_limit`;
  try {
    const res = await axios.post(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

setRiskLimit({
  symbol: 'BTC-PERP',
  riskLimitLevel: 2,
})
  .then(console.log)
  .catch(console.error);
