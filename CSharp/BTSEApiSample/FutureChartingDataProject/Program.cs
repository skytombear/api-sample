using FutureNS = FutureChartingDataProject;

var service = new FutureNS.FutureChartingData();
var response = await service.GetChartingDataAsync(new FutureNS.FutureChartingDataRequestEntity
{
    Symbol = "BTC-PERP",
    Resolution = 60,
});

System.Console.WriteLine(response);
