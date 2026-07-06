using WsNS = FutureWsPositionsProject;

var service = new WsNS.FutureWsPositions();
await service.StartListeningAsync();
