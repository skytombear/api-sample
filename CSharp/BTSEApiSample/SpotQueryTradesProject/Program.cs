using SpotNS = SpotQueryTradesProject;

var service = new SpotNS.SpotQueryTrades();
var response = await service.GetTradesAsync(new SpotNS.SpotQueryTradesRequestEntity
{
    Symbol = "BTC-USD",
    Count = 10,
});

System.Console.WriteLine(response);
