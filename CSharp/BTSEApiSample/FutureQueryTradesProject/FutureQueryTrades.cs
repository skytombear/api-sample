using BTSEApiSample.Common;
using Flurl;

namespace FutureQueryTradesProject;

public class FutureQueryTrades
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetTradesAsync(FutureQueryTradesRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.FuturesApiVersion}/trades";
        var url = Utils.GetFuturesFullUrl(endpoint)
            .SetQueryParams(new
            {
                symbol = requestEntity.Symbol,
                count = requestEntity.Count,
                includeOld = requestEntity.IncludeOld
            });

        try
        {
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return $"Error {response.StatusCode}: {await response.Content.ReadAsStringAsync()}";
        }
        catch (Exception ex)
        {
            return ex;
        }
    }
}
