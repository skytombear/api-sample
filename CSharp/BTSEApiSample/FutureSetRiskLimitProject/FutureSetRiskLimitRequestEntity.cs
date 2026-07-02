using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureSetRiskLimitProject;

public class FutureSetRiskLimitRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("riskLimitLevel")]
    [Required]
    public int RiskLimitLevel { get; set; }

}
