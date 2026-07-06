const webSocket = require('ws');
const { getAuthHeaders, getWsSpotUrl } = require('../utils/common');

const client = new webSocket(getWsSpotUrl());

client.onerror = () => {
  console.log('connection error');
};

client.onopen = () => {
  function authenticate() {
    if (client.readyState === client.OPEN) {
      const header = getAuthHeaders('/ws/spot');
      console.log('header: ' + JSON.stringify(header));

      const authPayload = {
        op: 'authKeyExpires',
        args: [header['request-api'], header['request-nonce'], header['request-sign']],
      };
      console.log('sending auth msg: ' + JSON.stringify(authPayload));
      client.send(JSON.stringify(authPayload));
    }
  }
  authenticate();
};

client.onclose = () => {
  console.log('echo-protocol client closed');
};

client.onmessage = (e) => {
  if (typeof e.data === 'string') {
    console.log("Received: '" + e.data + "'");
  }
};

process.on('SIGINT', () => {
  client.close();
  process.exit();
});
