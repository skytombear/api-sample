using SpotNS = SpotInvestOrdersProject;

var service = new SpotNS.SpotInvestOrders();
var response = await service.QueryOrdersAsync(new SpotNS.SpotInvestOrdersRequestEntity());

System.Console.WriteLine(response);
