using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotInvestRenewProject;

public class SpotInvestRenewRequestEntity
{
    [JsonPropertyName("orderId")]
    [Required]
    public string OrderId { get; set; }

    [JsonPropertyName("autoRenew")]
    [Required]
    public bool AutoRenew { get; set; }

}
