const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

const queryPositionMode = async (params) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/position_mode`;
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

queryPositionMode({
  symbol: 'BTC-PERP',
})
  .then(console.log)
  .catch(console.error);
