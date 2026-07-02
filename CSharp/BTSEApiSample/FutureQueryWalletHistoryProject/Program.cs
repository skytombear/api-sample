using FutureNS = FutureQueryWalletHistoryProject;

var service = new FutureNS.FutureQueryWalletHistory();
var response = await service.QueryWalletHistoryAsync(new FutureNS.FutureQueryWalletHistoryRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
