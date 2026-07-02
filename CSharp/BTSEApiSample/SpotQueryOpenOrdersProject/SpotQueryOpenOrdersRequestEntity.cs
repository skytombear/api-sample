using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotQueryOpenOrdersProject;

public class SpotQueryOpenOrdersRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
