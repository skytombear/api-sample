using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryMarginSettingProject;

public class FutureQueryMarginSettingRequestEntity
{
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Symbol { get; set; }

}
