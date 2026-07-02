const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

const getRiskLimit = async (params) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/risk_limit`;
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

getRiskLimit({
  symbol: 'BTC-PERP',
})
  .then(console.log)
  .catch(console.error);
