using BTSEApiSample.Common;
using Flurl;

namespace FutureQueryOrderProject;

public class FutureQueryOrder
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> QueryOrderAsync(FutureQueryOrderRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.FuturesApiVersion}/order";
        var url = Utils.GetFuturesFullUrl(endpoint)
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
