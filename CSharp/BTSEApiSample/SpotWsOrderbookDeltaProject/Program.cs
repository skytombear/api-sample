using SpotNS = SpotWsOrderbookDeltaProject;

var service = new SpotNS.SpotWsOrderbookDelta();
await service.StartListeningAsync();
