using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotOrderbookProject;

public class SpotOrderbookRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("group")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int? Group { get; set; }

}
