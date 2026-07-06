using FutureNS = FutureQueryTradesProject;

var service = new FutureNS.FutureQueryTrades();
var response = await service.GetTradesAsync(new FutureNS.FutureQueryTradesRequestEntity
{
    Symbol = "BTC-PERP",
    Count = 10,
    IncludeOld = true,
});

System.Console.WriteLine(response);
