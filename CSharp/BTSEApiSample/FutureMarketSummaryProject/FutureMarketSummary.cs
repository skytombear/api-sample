using BTSEApiSample.Common;
using Flurl;

namespace FutureMarketSummaryProject;

public class FutureMarketSummary
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetMarketSummaryAsync(FutureMarketSummaryRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.FuturesApiVersion}/market_summary";
        var url = Utils.GetFuturesFullUrl(endpoint)
            .SetQueryParams(new
            {
                symbol = requestEntity.Symbol
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
