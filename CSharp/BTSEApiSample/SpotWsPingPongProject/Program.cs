using SpotNS = SpotWsPingPongProject;

var service = new SpotNS.SpotWsPingPong();
await service.StartListeningAsync();
