using SpotNS = SpotWsPublicTradeFillsProject;

var service = new SpotNS.SpotWsPublicTradeFills();
await service.StartListeningAsync();
