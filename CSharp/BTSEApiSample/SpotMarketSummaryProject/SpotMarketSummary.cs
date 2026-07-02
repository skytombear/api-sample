using BTSEApiSample.Common;
using Flurl;

namespace SpotMarketSummaryProject;

public class SpotMarketSummary
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetMarketSummaryAsync(SpotMarketSummaryRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.SpotApiVersion}/market_summary";
        var url = Utils.GetSpotFullUrl(endpoint)
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
