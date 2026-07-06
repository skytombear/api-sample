using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryTradeHistoryProject;

public class FutureQueryTradeHistoryRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
