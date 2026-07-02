using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureGetRiskLimitProject;

public class FutureGetRiskLimitRequestEntity
{
    [JsonPropertyName("symbol")]
    [Required]
    public string Symbol { get; set; }

}
