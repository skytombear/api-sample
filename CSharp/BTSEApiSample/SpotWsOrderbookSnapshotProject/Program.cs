using SpotNS = SpotWsOrderbookSnapshotProject;

var service = new SpotNS.SpotWsOrderbookSnapshot();
await service.StartListeningAsync();
