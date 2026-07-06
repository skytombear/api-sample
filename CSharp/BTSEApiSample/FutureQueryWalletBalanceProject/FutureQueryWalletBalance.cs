using BTSEApiSample.Common;
using Flurl;

namespace FutureQueryWalletBalanceProject;

public class FutureQueryWalletBalance
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> QueryWalletBalanceAsync(FutureQueryWalletBalanceRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.FuturesApiVersion}/user/wallet";
        var url = Utils.GetFuturesFullUrl(endpoint)
            .SetQueryParams(new
            {
                wallet = requestEntity.Wallet
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
