using SpotNS = SpotCancelAllAfterProject;

var service = new SpotNS.SpotCancelAllAfter();
var response = await service.CancelAllAfterAsync(new SpotNS.SpotCancelAllAfterRequestEntity
{
    Timeout = 60000,
});

System.Console.WriteLine(response);
