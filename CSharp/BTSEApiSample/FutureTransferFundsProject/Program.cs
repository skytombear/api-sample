using FutureNS = FutureTransferFundsProject;

var service = new FutureNS.FutureTransferFunds();
var response = await service.TransferFundsAsync(new FutureNS.FutureTransferFundsRequestEntity
{
    WalletSrcType = "SPOT",
    WalletDestType = "CROSS",
    ApiWallets = new List<FutureNS.ApiWallet>
    {
        new() { Currency = "USDT", AllBalance = true },
    },
});

System.Console.WriteLine(response);
