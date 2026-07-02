using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotOrderbookL2Project;

public class SpotOrderbookL2RequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("depth")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int? Depth { get; set; }

}
