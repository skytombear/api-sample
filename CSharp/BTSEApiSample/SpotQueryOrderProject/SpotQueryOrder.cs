using BTSEApiSample.Common;
using Flurl;

namespace SpotQueryOrderProject;

public class SpotQueryOrder
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> QueryOrderAsync(SpotQueryOrderRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.SpotApiVersion}/order";
        var url = Utils.GetSpotFullUrl(endpoint)
            .SetQueryParams(new
            {
                orderID = requestEntity.OrderID,
                clOrderID = requestEntity.ClOrderID
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
