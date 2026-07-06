using FutureNS = FutureGetLeverageProject;

var service = new FutureNS.FutureGetLeverage();
var response = await service.GetLeverageAsync(new FutureNS.FutureGetLeverageRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
