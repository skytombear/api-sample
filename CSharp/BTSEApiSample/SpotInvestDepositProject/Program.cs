using SpotNS = SpotInvestDepositProject;

var service = new SpotNS.SpotInvestDeposit();
var response = await service.DepositAsync(new SpotNS.SpotInvestDepositRequestEntity
{
    ProductId = "your-product-id",
    Amount = 100,
});

System.Console.WriteLine(response);
