using FutureNS = FutureSubAccountTransferProject;

var service = new FutureNS.FutureSubAccountTransfer();
var response = await service.SubAccountTransferAsync(new FutureNS.FutureSubAccountTransferRequestEntity
{
    WalletSrcType = "CROSS",
    WalletDestType = "CROSS",
    FromUser = "source-username",
    Receiver = "receiver-username",
    ApiWallets = new List<FutureNS.ApiWallet>
    {
        new() { Currency = "USDT", AllBalance = true },
    },
});

System.Console.WriteLine(response);
