using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryPositionModeProject;

public class FutureQueryPositionModeRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
