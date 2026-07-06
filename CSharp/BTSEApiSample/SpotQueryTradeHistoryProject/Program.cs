using SpotNS = SpotQueryTradeHistoryProject;

var service = new SpotNS.SpotQueryTradeHistory();
var response = await service.QueryTradeHistoryAsync(new SpotNS.SpotQueryTradeHistoryRequestEntity
{
    Symbol = "BTC-USD",
});

System.Console.WriteLine(response);
