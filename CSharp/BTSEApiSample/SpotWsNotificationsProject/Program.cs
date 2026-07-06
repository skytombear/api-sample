using SpotNS = SpotWsNotificationsProject;

var service = new SpotNS.SpotWsNotifications();
await service.StartListeningAsync();
