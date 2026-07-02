using SpotNS = SpotInvestProductsProject;

var service = new SpotNS.SpotInvestProducts();
var response = await service.QueryProductsAsync(new SpotNS.SpotInvestProductsRequestEntity());

System.Console.WriteLine(response);
