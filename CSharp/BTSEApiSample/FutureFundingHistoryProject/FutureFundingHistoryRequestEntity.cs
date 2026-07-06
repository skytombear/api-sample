using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureFundingHistoryProject;

public class FutureFundingHistoryRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

    [JsonPropertyName("count")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int? Count { get; set; }

}
