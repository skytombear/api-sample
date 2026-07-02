using FutureNS = FutureQueryPositionProject;

var service = new FutureNS.FutureQueryPosition();
var response = await service.QueryPositionAsync(new FutureNS.FutureQueryPositionRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
