using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureChangeSettlementProject;

public class FutureChangeSettlementRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("currency")]
    [Required]
    public string Currency { get; set; }

}
