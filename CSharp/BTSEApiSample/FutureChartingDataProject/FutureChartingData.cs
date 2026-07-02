using BTSEApiSample.Common;
using Flurl;

namespace FutureChartingDataProject;

public class FutureChartingData
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetChartingDataAsync(FutureChartingDataRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.FuturesApiVersion}/ohlcv";
        var url = Utils.GetFuturesFullUrl(endpoint)
            .SetQueryParams(new
            {
                symbol = requestEntity.Symbol,
                resolution = requestEntity.Resolution
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
