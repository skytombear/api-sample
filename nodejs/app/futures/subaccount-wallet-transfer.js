const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

// Transfer funds between sub-accounts. Requires `fromUser` and `receiver`
// usernames in addition to the source/destination wallet types.
const subAccountWalletTransfer = async (body) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/subaccount/wallet/transfer`;
  try {
    const res = await axios.post(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

subAccountWalletTransfer({
  walletSrcType: 'CROSS',
  walletDestType: 'CROSS',
  fromUser: 'source-username',
  receiver: 'receiver-username',
  apiWallets: [{ currency: 'USDT', allBalance: true }],
})
  .then(console.log)
  .catch(console.error);
