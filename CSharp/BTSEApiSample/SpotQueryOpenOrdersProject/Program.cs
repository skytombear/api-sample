using SpotNS = SpotQueryOpenOrdersProject;

var service = new SpotNS.SpotQueryOpenOrders();
var response = await service.QueryOpenOrdersAsync(new SpotNS.SpotQueryOpenOrdersRequestEntity
{
    Symbol = "BTC-USD",
});

System.Console.WriteLine(response);
