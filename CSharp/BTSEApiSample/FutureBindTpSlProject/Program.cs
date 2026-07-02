using FutureNS = FutureBindTpSlProject;

var service = new FutureNS.FutureBindTpSl();
var response = await service.BindTpSlAsync(new FutureNS.FutureBindTpSlRequestEntity
{
    Symbol = "BTC-PERP",
    TakeProfitPrice = 31000,
    TakeProfitTrigger = "markPrice",
    StopLossPrice = 22000,
    StopLossTrigger = "lastPrice",
});

System.Console.WriteLine(response);
