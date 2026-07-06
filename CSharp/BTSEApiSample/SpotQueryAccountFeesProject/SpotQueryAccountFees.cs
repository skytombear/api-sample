using BTSEApiSample.Common;
using Flurl;

namespace SpotQueryAccountFeesProject;

public class SpotQueryAccountFees
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> QueryAccountFeesAsync(SpotQueryAccountFeesRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.SpotApiVersion}/user/fees";
        var url = Utils.GetSpotFullUrl(endpoint)
            .SetQueryParams(new
            {
                symbol = requestEntity.Symbol
            });

        var request = new HttpRequestMessage(HttpMethod.Get, url);
        foreach (var header in Utils.GetHeaders(endpoint))
        {
            request.Headers.Add(header.Key, header.Value);
        }

        try
        {
            var response = await _httpClient.SendAsync(request);
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
