using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryAccountFeesProject;

public class FutureQueryAccountFeesRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
