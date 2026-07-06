using SpotNS = SpotQueryOrderProject;

var service = new SpotNS.SpotQueryOrder();
var response = await service.QueryOrderAsync(new SpotNS.SpotQueryOrderRequestEntity
{
    OrderID = "your-order-id",
});

System.Console.WriteLine(response);
