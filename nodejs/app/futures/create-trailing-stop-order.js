const axios = require('axios');
const { FUTURES_API_VERSION } = require('../utils/constants');
const { getFuturesUrl, getAuthHeaders } = require('../utils/common');

const placeTrailingStopOrder = async ({
  size,
  price,
  side,
  timeInForce,
  type,
  symbol,
  txType,
  postOnly,
  reduceOnly,
  triggerPrice,
  stopPrice,
  trailValue,
  trailValueType,
  clOrderID,
  trigger,
}) => {
  const endpoint = `/api/${FUTURES_API_VERSION}/order`;
  const body = {
    size,
    price,
    side,
    time_in_force: timeInForce,
    type,
    symbol,
    txType,
    postOnly,
    reduceOnly,
    triggerPrice,
    stopPrice,
    trailValue,
    trailValueType,
    clOrderID,
    trigger,
  };
  try {
    const res = await axios.post(getFuturesUrl(endpoint), body, {
      headers: getAuthHeaders(endpoint, body),
    });
    return res.data;
  } catch (error) {
    return error.response.data;
  }
};

placeTrailingStopOrder({
  clOrderID: 'test-trailing-stop-order-placement',
  size: 1,
  side: 'BUY',
  timeInForce: 'GTC',
  symbol: 'BTC-PERP',
  type: 'MARKET',
  txType: 'TRIGGER',
  trigger: 'lastPrice', // markPrice or lastPrice
  trailValue: 0.05, // PERCENTAGE type, valid range [0.001, 0.99]
  trailValueType: 'PERCENTAGE', // required by the API
})
  .then(console.log)
  .catch(console.error);
