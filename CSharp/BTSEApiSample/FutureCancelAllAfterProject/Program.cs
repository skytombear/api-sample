using FutureNS = FutureCancelAllAfterProject;

var service = new FutureNS.FutureCancelAllAfter();
var response = await service.CancelAllAfterAsync(new FutureNS.FutureCancelAllAfterRequestEntity
{
    Timeout = 60000,
});

System.Console.WriteLine(response);
