using BTSEApiSample.Common;
using Flurl;

namespace SpotQueryMarketPriceProject;

public class SpotQueryMarketPrice
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetMarketPriceAsync(SpotQueryMarketRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.SpotApiVersion}/price";
        var url = Utils.GetSpotFullUrl(endpoint)
            .SetQueryParams(new
            {
                symbol = requestEntity.Symbol,
            });

        try
        {
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return $"Error: {response.StatusCode}";
        }
        catch (Exception ex)
        {
            return ex;
        }
    }
}