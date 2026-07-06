using FutureNS = FutureQueryPositionModeProject;

var service = new FutureNS.FutureQueryPositionMode();
var response = await service.QueryPositionModeAsync(new FutureNS.FutureQueryPositionModeRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
