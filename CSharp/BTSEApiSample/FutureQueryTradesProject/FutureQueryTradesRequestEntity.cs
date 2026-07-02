using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryTradesProject;

public class FutureQueryTradesRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("count")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int? Count { get; set; }

    [JsonPropertyName("includeOld")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool? IncludeOld { get; set; }

}
