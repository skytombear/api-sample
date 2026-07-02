using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryWalletMarginProject;

public class FutureQueryWalletMarginRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

}
