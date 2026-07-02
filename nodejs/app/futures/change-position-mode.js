const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

const changePositionMode = async (body) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/position_mode`;
  try {
    const res = await axios.post(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

// positionMode: ONE_WAY, HEDGE or ISOLATED
changePositionMode({
  symbol: 'BTC-PERP',
  positionMode: 'HEDGE',
})
  .then(console.log)
  .catch(console.error);
