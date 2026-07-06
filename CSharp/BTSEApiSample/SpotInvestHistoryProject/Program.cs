using SpotNS = SpotInvestHistoryProject;

var service = new SpotNS.SpotInvestHistory();
var response = await service.QueryHistoryAsync(new SpotNS.SpotInvestHistoryRequestEntity());

System.Console.WriteLine(response);
