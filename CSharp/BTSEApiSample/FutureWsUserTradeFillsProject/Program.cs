using WsNS = FutureWsUserTradeFillsProject;

var service = new WsNS.FutureWsUserTradeFills();
await service.StartListeningAsync();
