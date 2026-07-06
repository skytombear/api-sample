using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureBindTpSlProject;

public class FutureBindTpSlRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("takeProfitPrice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public double? TakeProfitPrice { get; set; }

    [JsonPropertyName("takeProfitTrigger")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string TakeProfitTrigger { get; set; }

    [JsonPropertyName("stopLossPrice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public double? StopLossPrice { get; set; }

    [JsonPropertyName("stopLossTrigger")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string StopLossTrigger { get; set; }

}
