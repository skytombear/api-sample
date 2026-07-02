using FutureNS = FutureCreateAlgoOrderProject;

var service = new FutureNS.FutureCreateAlgoOrder();
var response = await service.CreateAlgoOrderAsync(new FutureNS.FutureCreateAlgoOrderRequestEntity
{
    Symbol = "BTC-PERP",
    Price = 21500,
    Size = 1,
    Side = "BUY",
    ClOrderID = "test-algo-order",
    Stealth = 10,
    Deviation = -10,
});

System.Console.WriteLine(response);
