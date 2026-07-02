using BTSEApiSample.Common;
using Flurl;

namespace SpotOrderbookProject;

public class SpotOrderbook
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetOrderbookAsync(SpotOrderbookRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.SpotApiVersion}/orderbook";
        var url = Utils.GetSpotFullUrl(endpoint)
            .SetQueryParams(new
            {
                symbol = requestEntity.Symbol,
                group = requestEntity.Group
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
