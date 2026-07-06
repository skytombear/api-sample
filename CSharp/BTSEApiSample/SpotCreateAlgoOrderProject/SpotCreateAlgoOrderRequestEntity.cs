using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotCreateAlgoOrderProject;

public class SpotCreateAlgoOrderRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("price")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public double? Price { get; set; }

    [JsonPropertyName("size")]
    [Required]
    public double Size { get; set; }

    [JsonPropertyName("side")]
    [Required]
    public string Side { get; set; }

}
