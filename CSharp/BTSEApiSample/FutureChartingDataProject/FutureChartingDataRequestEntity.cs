using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureChartingDataProject;

public class FutureChartingDataRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("resolution")]
    [Required]
    public long Resolution { get; set; }

}
