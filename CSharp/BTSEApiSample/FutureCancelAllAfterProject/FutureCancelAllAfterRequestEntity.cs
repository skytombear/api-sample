using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureCancelAllAfterProject;

public class FutureCancelAllAfterRequestEntity
{
    [JsonPropertyName("timeout")]
    [Required]
    public long Timeout { get; set; }

}
