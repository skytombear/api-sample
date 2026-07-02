using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureQueryWalletBalanceProject;

public class FutureQueryWalletBalanceRequestEntity
{
    [JsonPropertyName("wallet")]
    [Required]
    public string Wallet { get; set; }

}
