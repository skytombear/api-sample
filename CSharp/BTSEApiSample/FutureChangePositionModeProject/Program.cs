using FutureNS = FutureChangePositionModeProject;

var service = new FutureNS.FutureChangePositionMode();
var response = await service.ChangePositionModeAsync(new FutureNS.FutureChangePositionModeRequestEntity
{
    Symbol = "BTC-PERP",
    PositionMode = "HEDGE",
});

System.Console.WriteLine(response);
