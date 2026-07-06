using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureOrderbookL2Project;

public class FutureOrderbookL2RequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("depth")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int? Depth { get; set; }

}
