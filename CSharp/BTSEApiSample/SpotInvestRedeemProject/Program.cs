using SpotNS = SpotInvestRedeemProject;

var service = new SpotNS.SpotInvestRedeem();
var response = await service.RedeemAsync(new SpotNS.SpotInvestRedeemRequestEntity
{
    OrderId = "your-order-id",
    Amount = 100,
});

System.Console.WriteLine(response);
