using FutureNS = FutureQueryMarginSettingProject;

var service = new FutureNS.FutureQueryMarginSetting();
var response = await service.QueryMarginSettingAsync(new FutureNS.FutureQueryMarginSettingRequestEntity
{
    Symbol = "BTC-PERP",
});

System.Console.WriteLine(response);
