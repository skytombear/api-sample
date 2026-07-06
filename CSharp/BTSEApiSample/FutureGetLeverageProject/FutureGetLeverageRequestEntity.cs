using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureGetLeverageProject;

public class FutureGetLeverageRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

}
