using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureSetLeverageProject;

public class FutureSetLeverageRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

    [JsonPropertyName("leverage")]
    [Required]
    public double Leverage { get; set; }

}
