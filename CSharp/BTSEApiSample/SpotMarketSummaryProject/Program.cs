using SpotNS = SpotMarketSummaryProject;

var service = new SpotNS.SpotMarketSummary();
var response = await service.GetMarketSummaryAsync(new SpotNS.SpotMarketSummaryRequestEntity
{
    Symbol = "BTC-USD",
});

System.Console.WriteLine(response);
