using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryOrderProject;

public class FutureQueryOrderRequestEntity
{
    [JsonPropertyName("orderID")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string OrderID { get; set; }

    [JsonPropertyName("clOrderID")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string ClOrderID { get; set; }

}
