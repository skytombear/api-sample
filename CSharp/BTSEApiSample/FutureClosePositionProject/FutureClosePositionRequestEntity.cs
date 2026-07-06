using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureClosePositionProject;

public class FutureClosePositionRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("type")]
    [Required]
    public string Type { get; set; }

    [JsonPropertyName("price")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public double? Price { get; set; }

}
