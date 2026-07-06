using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotMarketSummaryProject;

public class SpotMarketSummaryRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
