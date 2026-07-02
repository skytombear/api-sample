using System.Text.Json.Serialization;

namespace SpotCancelOrderProject;

public class SpotCancelOrderResponseEntity
{
    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("orderType")]
    public int OrderType { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("side")]
    public string Side { get; set; }

    [JsonPropertyName("orderID")]
    public string OrderID { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("triggerPrice")]
    public decimal TriggerPrice { get; set; }

    [JsonPropertyName("stopPrice")]
    public decimal? StopPrice { get; set; }

    [JsonPropertyName("trigger")]
    public bool Trigger { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("averageFillPrice")]
    public decimal AverageFillPrice { get; set; }

    [JsonPropertyName("clOrderID")]
    public string ClOrderID { get; set; }

    [JsonPropertyName("stealth")]
    public double Stealth { get; set; }

    [JsonPropertyName("deviation")]
    public double Deviation { get; set; }

    [JsonPropertyName("postOnly")]
    public bool PostOnly { get; set; }

    [JsonPropertyName("originalOrderBaseSize")]
    public decimal OriginalOrderBaseSize { get; set; }

    [JsonPropertyName("originalOrderQuoteSize")]
    public decimal OriginalOrderQuoteSize { get; set; }

    [JsonPropertyName("currentOrderBaseSize")]
    public decimal CurrentOrderBaseSize { get; set; }

    [JsonPropertyName("currentOrderQuoteSize")]
    public decimal CurrentOrderQuoteSize { get; set; }

    [JsonPropertyName("remainingOrderBaseSize")]
    public decimal RemainingOrderBaseSize { get; set; }

    [JsonPropertyName("remainingOrderQuoteSize")]
    public decimal RemainingOrderQuoteSize { get; set; }

    [JsonPropertyName("filledBaseSize")]
    public decimal FilledBaseSize { get; set; }

    [JsonPropertyName("totalFilledBaseSize")]
    public decimal TotalFilledBaseSize { get; set; }

    [JsonPropertyName("orderCurrency")]
    public string OrderCurrency { get; set; }

    [JsonPropertyName("time_in_force")]
    public string TimeInForce { get; set; }
}