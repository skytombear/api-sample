using WsNS = FutureWsPublicTradeFillsProject;

var service = new WsNS.FutureWsPublicTradeFills();
await service.StartListeningAsync();
