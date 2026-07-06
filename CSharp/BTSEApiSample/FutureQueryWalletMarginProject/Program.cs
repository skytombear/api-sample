using FutureNS = FutureQueryWalletMarginProject;

var service = new FutureNS.FutureQueryWalletMargin();
var response = await service.QueryWalletMarginAsync(new FutureNS.FutureQueryWalletMarginRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
