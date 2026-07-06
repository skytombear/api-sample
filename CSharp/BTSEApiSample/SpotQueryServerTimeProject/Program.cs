using SpotNS = SpotQueryServerTimeProject;

var service = new SpotNS.SpotQueryServerTime();
var response = await service.GetServerTimeAsync(new SpotNS.SpotQueryServerTimeRequestEntity());

System.Console.WriteLine(response);
