using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryPositionProject;

public class FutureQueryPositionRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
