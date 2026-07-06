using System.Net.WebSockets;
using System.Text;
using BTSEApiSample.Common;

namespace SpotWsPingPongProject;

public class SpotWsPingPong
{
    private readonly ClientWebSocket _webSocket = new();

    public async Task StartListeningAsync()
    {
        var wsUri = new Uri(Utils.GetSpotWsUrl());
        try
        {
            await _webSocket.ConnectAsync(wsUri, CancellationToken.None);

            // Heartbeat: send the literal text frame "ping"; the server replies "pong".
            var ping = Encoding.UTF8.GetBytes("ping");
            await _webSocket.SendAsync(new ArraySegment<byte>(ping), WebSocketMessageType.Text, true, CancellationToken.None);

            var buffer = new byte[1024];
            while (_webSocket.State == WebSocketState.Open)
            {
                var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                    Console.WriteLine("### socket closed ###");
                }
                else
                {
                    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, result.Count));
                }
            }
        }
        catch (Exception e) { Console.WriteLine(e.Message); }
    }
}
