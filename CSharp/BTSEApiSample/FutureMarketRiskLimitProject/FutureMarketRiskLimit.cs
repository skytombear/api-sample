using BTSEApiSample.Common;
using Flurl;

namespace FutureMarketRiskLimitProject;

public class FutureMarketRiskLimit
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetMarketRiskLimitAsync(FutureMarketRiskLimitRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.FuturesApiVersion}/market/risk_limit";
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
