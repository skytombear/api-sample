using FutureNS = FutureQueryTradeHistoryProject;

var service = new FutureNS.FutureQueryTradeHistory();
var response = await service.QueryTradeHistoryAsync(new FutureNS.FutureQueryTradeHistoryRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
