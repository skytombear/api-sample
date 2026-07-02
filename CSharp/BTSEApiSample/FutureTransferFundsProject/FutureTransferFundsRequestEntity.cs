using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureTransferFundsProject;

public class FutureTransferFundsRequestEntity
{
    [JsonPropertyName("walletSrc")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string WalletSrc { get; set; }

    [JsonPropertyName("walletSrcType")]
    [Required]
    public string WalletSrcType { get; set; }

    [JsonPropertyName("walletDest")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string WalletDest { get; set; }

    [JsonPropertyName("walletDestType")]
    [Required]
    public string WalletDestType { get; set; }

    [JsonPropertyName("apiWallets")]
    [Required]
    public List<ApiWallet> ApiWallets { get; set; }
}

public class ApiWallet
{
    [JsonPropertyName("currency")]
    [Required]
    public string Currency { get; set; }

    [JsonPropertyName("allBalance")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool? AllBalance { get; set; }
}
