using SpotNS = SpotQueryAccountFeesProject;

var service = new SpotNS.SpotQueryAccountFees();
var response = await service.QueryAccountFeesAsync(new SpotNS.SpotQueryAccountFeesRequestEntity
{
    Symbol = "BTC-USD",
});

System.Console.WriteLine(response);
