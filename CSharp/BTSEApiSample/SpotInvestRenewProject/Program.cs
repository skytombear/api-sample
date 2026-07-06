using SpotNS = SpotInvestRenewProject;

var service = new SpotNS.SpotInvestRenew();
var response = await service.RenewAsync(new SpotNS.SpotInvestRenewRequestEntity
{
    OrderId = "your-order-id",
    AutoRenew = true,
});

System.Console.WriteLine(response);
