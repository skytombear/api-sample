using BTSEApiSample.Common;
using Flurl;

namespace SpotChartingDataProject;

public class SpotChartingData
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetChartingDataAsync(SpotChartingDataRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.SpotApiVersion}/ohlcv";
        var url = Utils.GetSpotFullUrl(endpoint)
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
