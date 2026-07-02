using FutureNS = FutureAmendOrderProject;

var service = new FutureNS.FutureAmendOrder();
var response = await service.AmendOrderAsync(new FutureNS.FutureAmendOrderRequestEntity
{
    Symbol = "BTC-PERP",
    OrderID = "your-order-id",
    Type = "PRICE",
    Value = 22000,
});

System.Console.WriteLine(response);
