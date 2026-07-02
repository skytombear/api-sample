using WsNS = FutureWsAllPositionProject;

var service = new WsNS.FutureWsAllPosition();
await service.StartListeningAsync();
