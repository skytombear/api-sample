using FutureNS = FutureQueryOrderProject;

var service = new FutureNS.FutureQueryOrder();
var response = await service.QueryOrderAsync(new FutureNS.FutureQueryOrderRequestEntity
{
    OrderID = "your-order-id",
});

System.Console.WriteLine(response);
