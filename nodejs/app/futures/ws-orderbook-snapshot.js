const webSocket = require('ws');
const { getWsOssFuturesUrl } = require('../utils/common');

// OSS best bid/ask (BBO) snapshot stream, on the dedicated /oss/futures host.
const client = new webSocket(getWsOssFuturesUrl());

client.onerror = () => {
  console.log('connection error');
};

client.onopen = () => {
  function subscribe() {
    if (client.readyState === client.OPEN) {
      const payload = {
        op: 'subscribe',
        args: ['snapshotL1:BTC-PERP'],
      };
      console.log('sending msg: ' + JSON.stringify(payload));
      client.send(JSON.stringify(payload));
    }
  }
  subscribe();
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
