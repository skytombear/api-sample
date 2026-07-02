using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryWalletHistoryProject;

public class FutureQueryWalletHistoryRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
