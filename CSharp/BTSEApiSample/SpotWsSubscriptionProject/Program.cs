using SpotNS = SpotWsSubscriptionProject;

var service = new SpotNS.SpotWsSubscription();
await service.StartListeningAsync();
