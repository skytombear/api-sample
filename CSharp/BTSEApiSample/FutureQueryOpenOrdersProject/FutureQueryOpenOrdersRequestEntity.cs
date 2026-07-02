using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryOpenOrdersProject;

public class FutureQueryOpenOrdersRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
