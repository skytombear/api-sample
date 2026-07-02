using FutureNS = FutureQueryOpenOrdersProject;

var service = new FutureNS.FutureQueryOpenOrders();
var response = await service.QueryOpenOrdersAsync(new FutureNS.FutureQueryOpenOrdersRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
