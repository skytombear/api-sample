using BTSEApiSample.Common;
using Flurl;

namespace FutureFundingHistoryProject;

public class FutureFundingHistory
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetFundingHistoryAsync(FutureFundingHistoryRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.FuturesApiVersion}/funding_history";
        var url = Utils.GetFuturesFullUrl(endpoint)
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
