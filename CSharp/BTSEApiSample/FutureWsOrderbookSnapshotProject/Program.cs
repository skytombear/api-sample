using WsNS = FutureWsOrderbookSnapshotProject;

var service = new WsNS.FutureWsOrderbookSnapshot();
await service.StartListeningAsync();
