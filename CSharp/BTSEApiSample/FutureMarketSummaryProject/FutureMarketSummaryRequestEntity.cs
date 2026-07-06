using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureMarketSummaryProject;

public class FutureMarketSummaryRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
