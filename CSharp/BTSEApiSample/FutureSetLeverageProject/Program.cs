using FutureNS = FutureSetLeverageProject;

var service = new FutureNS.FutureSetLeverage();
var response = await service.SetLeverageAsync(new FutureNS.FutureSetLeverageRequestEntity
{
    Symbol = "BTC-PERP",
    Leverage = 0,
});

System.Console.WriteLine(response);
