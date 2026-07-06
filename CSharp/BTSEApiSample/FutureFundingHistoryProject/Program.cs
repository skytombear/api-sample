using FutureNS = FutureFundingHistoryProject;

var service = new FutureNS.FutureFundingHistory();
var response = await service.GetFundingHistoryAsync(new FutureNS.FutureFundingHistoryRequestEntity
{
    Symbol = "BTC-PERP",
    Count = 10,
});

System.Console.WriteLine(response);
