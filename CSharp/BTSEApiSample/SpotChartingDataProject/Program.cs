using SpotNS = SpotChartingDataProject;

var service = new SpotNS.SpotChartingData();
var response = await service.GetChartingDataAsync(new SpotNS.SpotChartingDataRequestEntity
{
    Symbol = "BTC-USD",
    Resolution = 60,
});

System.Console.WriteLine(response);
