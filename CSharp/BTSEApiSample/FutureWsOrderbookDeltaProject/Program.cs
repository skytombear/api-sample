using WsNS = FutureWsOrderbookDeltaProject;

var service = new WsNS.FutureWsOrderbookDelta();
await service.StartListeningAsync();
