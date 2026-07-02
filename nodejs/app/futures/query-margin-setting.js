const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

// Query user initial margin percentage and maintenance margin percentage.
const queryMarginSetting = async (params) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/user/margin_setting`;
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

queryMarginSetting({
  symbol: 'BTC-PERP',
})
  .then(console.log)
  .catch(console.error);
