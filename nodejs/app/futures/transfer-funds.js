const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

// Transfer funds between futures wallets (SPOT / CROSS / ISOLATED).
const transferFunds = async (body) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/user/wallet/transfer`;
  try {
    const res = await axios.post(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

transferFunds({
  amount: 1,
  asset: 'USDT',
  fromWallet: 'CROSS@',
  toWallet: 'ISOLATED@BTC-PERP',
})
  .then(console.log)
  .catch(console.error);
