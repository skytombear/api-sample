using System.Text;
using System.Text.Json;
using BTSEApiSample.Common;

namespace FutureAmendOrderProject;

public class FutureAmendOrder
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> AmendOrderAsync(FutureAmendOrderRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.FuturesApiVersion}/order";
        var requestBody = JsonSerializer.Serialize(requestEntity);
        var request = new HttpRequestMessage(HttpMethod.Put, Utils.GetFuturesFullUrl(endpoint))
        {
            Content = new StringContent(requestBody, Encoding.UTF8, "application/json"),
        };

        foreach (var header in Utils.GetHeaders(endpoint, requestBody))
        {
            request.Headers.Add(header.Key, header.Value);
        }

        try
        {
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode is false)
            {
                Console.WriteLine($"Error message: {await response.Content.ReadAsStringAsync()}");
            }

            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            return ex;
        }
    }
}
