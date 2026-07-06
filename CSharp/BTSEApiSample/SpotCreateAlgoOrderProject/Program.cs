using SpotNS = SpotCreateAlgoOrderProject;

var service = new SpotNS.SpotCreateAlgoOrder();
var response = await service.CreateAlgoOrderAsync(new SpotNS.SpotCreateAlgoOrderRequestEntity
{
    Symbol = "BTC-USD",
    Price = 60000,
    Size = 0.01,
    Side = "BUY",
});

System.Console.WriteLine(response);
