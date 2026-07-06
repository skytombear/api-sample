using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotQueryTradeHistoryProject;

public class SpotQueryTradeHistoryRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
