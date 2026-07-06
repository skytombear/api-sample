using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotInvestRedeemProject;

public class SpotInvestRedeemRequestEntity
{
    [JsonPropertyName("orderId")]
    [Required]
    public string OrderId { get; set; }

    [JsonPropertyName("amount")]
    [Required]
    public double Amount { get; set; }

}
