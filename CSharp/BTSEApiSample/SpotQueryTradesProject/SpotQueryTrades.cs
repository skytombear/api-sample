using BTSEApiSample.Common;
using Flurl;

namespace SpotQueryTradesProject;

public class SpotQueryTrades
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetTradesAsync(SpotQueryTradesRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.SpotApiVersion}/trades";
        var url = Utils.GetSpotFullUrl(endpoint)
            .SetQueryParams(new
            {
                symbol = requestEntity.Symbol,
                count = requestEntity.Count
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
