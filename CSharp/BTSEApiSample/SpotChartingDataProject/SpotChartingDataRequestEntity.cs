using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotChartingDataProject;

public class SpotChartingDataRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("resolution")]
    [Required]
    public long Resolution { get; set; }

}
