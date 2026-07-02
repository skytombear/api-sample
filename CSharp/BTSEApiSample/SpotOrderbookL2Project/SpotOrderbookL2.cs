using BTSEApiSample.Common;
using Flurl;

namespace SpotOrderbookL2Project;

public class SpotOrderbookL2
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetOrderbookL2Async(SpotOrderbookL2RequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.SpotApiVersion}/orderbook/L2";
        var url = Utils.GetSpotFullUrl(endpoint)
            .SetQueryParams(new
            {
                symbol = requestEntity.Symbol,
                depth = requestEntity.Depth
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
