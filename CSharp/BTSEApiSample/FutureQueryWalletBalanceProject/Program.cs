using FutureNS = FutureQueryWalletBalanceProject;

var service = new FutureNS.FutureQueryWalletBalance();
var response = await service.QueryWalletBalanceAsync(new FutureNS.FutureQueryWalletBalanceRequestEntity
{
    Wallet = "CROSS@",
});

System.Console.WriteLine(response);
