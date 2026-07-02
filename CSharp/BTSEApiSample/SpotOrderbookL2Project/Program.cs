using SpotNS = SpotOrderbookL2Project;

var service = new SpotNS.SpotOrderbookL2();
var response = await service.GetOrderbookL2Async(new SpotNS.SpotOrderbookL2RequestEntity
{
    Symbol = "BTC-USD",
    Depth = 10,
});

System.Console.WriteLine(response);
