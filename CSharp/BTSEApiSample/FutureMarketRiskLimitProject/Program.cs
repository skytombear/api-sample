using FutureNS = FutureMarketRiskLimitProject;

var service = new FutureNS.FutureMarketRiskLimit();
var response = await service.GetMarketRiskLimitAsync(new FutureNS.FutureMarketRiskLimitRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
