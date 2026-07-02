using FutureNS = FutureQueryUnifiedWalletMarginProject;

var service = new FutureNS.FutureQueryUnifiedWalletMargin();
var response = await service.QueryUnifiedWalletMarginAsync(new FutureNS.FutureQueryUnifiedWalletMarginRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
