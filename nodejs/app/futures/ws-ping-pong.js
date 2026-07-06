const webSocket = require('ws');
const { getWsFuturesUrl } = require('../utils/common');

const client = new webSocket(getWsFuturesUrl());

client.onerror = () => {
  console.log('connection error');
};

client.onopen = () => {
  function subscribe() {
    if (client.readyState === client.OPEN) {
      const payload = 'ping';
      console.log('sending msg: ' + payload);
      client.send(payload);
      console.log('\n\nwaiting for pong...\n\n');
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
