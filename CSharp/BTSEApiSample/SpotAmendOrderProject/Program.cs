using SpotNS = SpotAmendOrderProject;

var service = new SpotNS.SpotAmendOrder();
var response = await service.AmendOrderAsync(new SpotNS.SpotAmendOrderRequestEntity
{
    Symbol = "BTC-USD",
    OrderID = "your-order-id",
    Type = "PRICE",
    Value = 60000,
});

System.Console.WriteLine(response);
