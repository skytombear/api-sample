using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureCreateAlgoOrderProject;

public class FutureCreateAlgoOrderRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("price")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public double? Price { get; set; }

    [JsonPropertyName("size")]
    [Required]
    public long Size { get; set; }

    [JsonPropertyName("side")]
    [Required]
    public string Side { get; set; }

    [JsonPropertyName("clOrderID")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string ClOrderID { get; set; }

    [JsonPropertyName("stealth")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public double? Stealth { get; set; }

    [JsonPropertyName("deviation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public double? Deviation { get; set; }

}
