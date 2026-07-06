using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureMarketRiskLimitProject;

public class FutureMarketRiskLimitRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
