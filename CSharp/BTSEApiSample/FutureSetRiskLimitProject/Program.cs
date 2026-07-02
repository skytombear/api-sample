using FutureNS = FutureSetRiskLimitProject;

var service = new FutureNS.FutureSetRiskLimit();
var response = await service.SetRiskLimitAsync(new FutureNS.FutureSetRiskLimitRequestEntity
{
    Symbol = "BTC-PERP",
    RiskLimitLevel = 2,
});

System.Console.WriteLine(response);
