using FutureNS = FutureOrderbookL2Project;

var service = new FutureNS.FutureOrderbookL2();
var response = await service.GetOrderbookL2Async(new FutureNS.FutureOrderbookL2RequestEntity
{
    Symbol = "BTC-PERP",
    Depth = 10,
});

System.Console.WriteLine(response);
