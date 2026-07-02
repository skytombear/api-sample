using SpotNS = SpotWsUserTradeFillsProject;

var service = new SpotNS.SpotWsUserTradeFills();
await service.StartListeningAsync();
