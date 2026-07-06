using FutureNS = FutureGetRiskLimitProject;

var service = new FutureNS.FutureGetRiskLimit();
var response = await service.GetRiskLimitAsync(new FutureNS.FutureGetRiskLimitRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
