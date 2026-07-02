using WsNS = FutureWsSubscriptionProject;

var service = new WsNS.FutureWsSubscription();
await service.StartListeningAsync();
