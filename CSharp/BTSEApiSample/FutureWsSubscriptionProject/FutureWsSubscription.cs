using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using BTSEApiSample.Common;
using BTSEApiSample.Common.Entities;

namespace FutureWsSubscriptionProject;

public class FutureWsSubscription
{
    private readonly ClientWebSocket _webSocket = new();

    private void OnMessage(string message) => Console.WriteLine(message);
    private void OnError(Exception ex) => Console.WriteLine(ex.Message);
    private void OnClose() => Console.WriteLine("### socket closed ###");

    private async Task SendAsync(string json)
    {
        var bytes = Encoding.UTF8.GetBytes(json);
        await _webSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None);
    }

    private async Task OnOpenAsync()
    {
        var subscribe = new WsSubscriptionRequestEntity("subscribe", new[] { "tradeHistoryApiV3:BTC-PERP" });
        await SendAsync(JsonSerializer.Serialize(subscribe));
    }

    public async Task StartListeningAsync()
    {
        var wsUri = new Uri(Utils.GetFuturesWsUrl());
        try
        {
            await _webSocket.ConnectAsync(wsUri, CancellationToken.None);
            await OnOpenAsync();

            var buffer = new byte[1024 * 4];
            while (_webSocket.State == WebSocketState.Open)
            {
                var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                    OnClose();
                }
                else
                {
                    OnMessage(Encoding.UTF8.GetString(buffer, 0, result.Count));
                }
            }
        }
        catch (WebSocketException wsEx) { OnError(wsEx); }
        catch (Exception e) { OnError(e); }
    }
}
