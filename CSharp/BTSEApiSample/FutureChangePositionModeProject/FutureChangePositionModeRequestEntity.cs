using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureChangePositionModeProject;

public class FutureChangePositionModeRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("positionMode")]
    [Required]
    public string PositionMode { get; set; }

}
