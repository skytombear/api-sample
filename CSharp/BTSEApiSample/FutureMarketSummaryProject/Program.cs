using FutureNS = FutureMarketSummaryProject;

var service = new FutureNS.FutureMarketSummary();
var response = await service.GetMarketSummaryAsync(new FutureNS.FutureMarketSummaryRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
