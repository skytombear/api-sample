using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotQueryAccountFeesProject;

public class SpotQueryAccountFeesRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
