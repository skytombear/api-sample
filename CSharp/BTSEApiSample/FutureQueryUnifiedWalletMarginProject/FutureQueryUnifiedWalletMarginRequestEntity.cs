using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryUnifiedWalletMarginProject;

public class FutureQueryUnifiedWalletMarginRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
