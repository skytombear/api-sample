using BTSEApiSample.Common;
using Flurl;

namespace FutureOrderbookProject;

public class FutureOrderbook
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetOrderbookAsync(FutureOrderbookRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.FuturesApiVersion}/orderbook";
        var url = Utils.GetFuturesFullUrl(endpoint)
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
