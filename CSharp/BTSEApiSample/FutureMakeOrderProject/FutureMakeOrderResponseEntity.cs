using System.Text.Json.Serialization;

namespace FutureMakeOrderProject;

public class FutureMakeOrderResponseEntity
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("clOrderID")]
    public string ClOrderID { get; set; }

    [JsonPropertyName("orderID")]
    public string OrderID { get; set; }

    [JsonPropertyName("orderType")]
    public int OrderType { get; set; }

    [JsonPropertyName("postOnly")]
    public bool PostOnly { get; set; }

    [JsonPropertyName("price")]
    public double Price { get; set; }

    [JsonPropertyName("side")]
    public string Side { get; set; }

    [JsonPropertyName("status")]
    public long Status { get; set; }

    [JsonPropertyName("time_in_force")]
    public string TimeInForce { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("trigger")]
    public bool Trigger { get; set; }

    [JsonPropertyName("triggerPrice")]
    public double TriggerPrice { get; set; }

    [JsonPropertyName("avgFilledPrice")]
    public double AvgFilledPrice { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("stealth")]
    public double Stealth { get; set; }

    [JsonPropertyName("deviation")]
    public double Deviation { get; set; }

    [JsonPropertyName("remainingSize")]
    public double RemainingSize { get; set; }

    [JsonPropertyName("originalOrderSize")]
    public long OriginalOrderSize { get; set; }

    [JsonPropertyName("currentOrderSize")]
    public long CurrentOrderSize { get; set; }

    [JsonPropertyName("filledSize")]
    public long FilledSize { get; set; }

    [JsonPropertyName("totalFilledSize")]
    public long TotalFilledSize { get; set; }
}