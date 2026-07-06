using SpotNS = SpotOrderbookProject;

var service = new SpotNS.SpotOrderbook();
var response = await service.GetOrderbookAsync(new SpotNS.SpotOrderbookRequestEntity
{
    Symbol = "BTC-USD",
    Group = 1,
});

System.Console.WriteLine(response);
