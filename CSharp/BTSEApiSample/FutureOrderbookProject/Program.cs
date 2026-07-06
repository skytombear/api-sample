using FutureNS = FutureOrderbookProject;

var service = new FutureNS.FutureOrderbook();
var response = await service.GetOrderbookAsync(new FutureNS.FutureOrderbookRequestEntity
{
    Symbol = "BTC-PERP",
    Group = 2,
});

System.Console.WriteLine(response);
