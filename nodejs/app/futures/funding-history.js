const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl } = require('../utils/common');

const getFundingHistory = async (params) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/funding_history`;
  try {
    const res = await axios.get(getFuturesUrl(endpoint), {
      params,
    });
    return res.data;
  } catch (error) {
    return error;
  }
};

// `count` is mutually exclusive with `from`/`to`.
getFundingHistory({
  symbol: 'BTC-PERP',
  count: 10,
})
  .then(console.log)
  .catch(console.error);
