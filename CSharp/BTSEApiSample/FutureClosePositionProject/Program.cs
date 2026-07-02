using FutureNS = FutureClosePositionProject;

var service = new FutureNS.FutureClosePosition();
var response = await service.ClosePositionAsync(new FutureNS.FutureClosePositionRequestEntity
{
    Symbol = "BTC-PERP",
    Type = "MARKET",
    Price = 0,
});

System.Console.WriteLine(response);
