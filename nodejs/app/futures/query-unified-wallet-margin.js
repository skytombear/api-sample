const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

// For users who have upgraded to the unified wallet.
const queryUnifiedWalletMargin = async (params) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/user/unifiedWallet/margin`;
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

queryUnifiedWalletMargin({
  symbol: 'BTC-PERP',
})
  .then(console.log)
  .catch(console.error);
