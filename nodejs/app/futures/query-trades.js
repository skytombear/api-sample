const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl } = require('../utils/common');

// Public recent trades (no auth required).
const getTrades = async (params) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/trades`;
  try {
    const res = await axios.get(getFuturesUrl(endpoint), { params });
    return res.data;
  } catch (error) {
    return error.response ? error.response.data : error;
  }
};

getTrades({ symbol: 'BTC-PERP' }).then(console.log).catch(console.error);
