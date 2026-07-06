using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotQueryTradesProject;

public class SpotQueryTradesRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("count")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int? Count { get; set; }

}
