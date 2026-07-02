using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotInvestDepositProject;

public class SpotInvestDepositRequestEntity
{
    [JsonPropertyName("productId")]
    [Required]
    public string ProductId { get; set; }

    [JsonPropertyName("amount")]
    [Required]
    public double Amount { get; set; }

}
