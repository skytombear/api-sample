using WsNS = FutureWsNotificationsProject;

var service = new WsNS.FutureWsNotifications();
await service.StartListeningAsync();
