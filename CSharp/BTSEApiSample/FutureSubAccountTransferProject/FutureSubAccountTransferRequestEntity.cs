using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FutureSubAccountTransferProject;

public class FutureSubAccountTransferRequestEntity
{
    [JsonPropertyName("walletSrcType")]
    [Required]
    public string WalletSrcType { get; set; }

    [JsonPropertyName("walletDestType")]
    [Required]
    public string WalletDestType { get; set; }

    [JsonPropertyName("fromUser")]
    [Required]
    public string FromUser { get; set; }

    [JsonPropertyName("receiver")]
    [Required]
    public string Receiver { get; set; }

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
