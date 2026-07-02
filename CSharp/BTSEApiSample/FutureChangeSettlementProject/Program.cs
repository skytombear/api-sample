using FutureNS = FutureChangeSettlementProject;

var service = new FutureNS.FutureChangeSettlement();
var response = await service.ChangeSettlementAsync(new FutureNS.FutureChangeSettlementRequestEntity
{
    Symbol = "BTC-PERP",
    Currency = "USDT",
});

System.Console.WriteLine(response);
