using FutureNS = FutureQueryAccountFeesProject;

var service = new FutureNS.FutureQueryAccountFees();
var response = await service.QueryAccountFeesAsync(new FutureNS.FutureQueryAccountFeesRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
