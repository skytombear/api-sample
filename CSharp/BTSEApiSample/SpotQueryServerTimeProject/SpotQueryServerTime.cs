using BTSEApiSample.Common;
using Flurl;

namespace SpotQueryServerTimeProject;

public class SpotQueryServerTime
{
    private readonly HttpClient _httpClient = new();

    public async Task<object> GetServerTimeAsync(SpotQueryServerTimeRequestEntity requestEntity)
    {
        const string endpoint = $"/api/{ApiConstants.SpotApiVersion}/time";
        var url = Utils.GetSpotFullUrl(endpoint);

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
