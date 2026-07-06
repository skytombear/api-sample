using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotCancelAllAfterProject;

public class SpotCancelAllAfterRequestEntity
{
    [JsonPropertyName("timeout")]
    [Required]
    public long Timeout { get; set; }

}
