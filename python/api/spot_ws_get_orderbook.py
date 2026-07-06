#!/usr/bin/env python3

import websocket
import json
from utils import get_env_info, get_spot_ws_url


def on_message(ws, message):
    print(json.dumps(json.loads(message), indent=2))


def on_error(ws, error):
    print(error)


def on_close(ws, close_status_code, close_msg):
    print("### socket closed ###")


def on_open(ws):
    # DEPRECATED (V3.3): the `orderBookApi` websocket topic has been removed.
    # Grouped orderbook is now REST-only (GET /api/v3.3/orderbook). For realtime
    # updates use the OSS streams instead: `update:<symbol>_<grouping>` (see
    # spot_ws_get_oss_delta.py) or `snapshotL1:<symbol>` (spot_ws_get_oss_snapshot.py).
    payload = {
        "op": "subscribe",
        "args": ["orderBookApi:BTC-USD_0"],
    }
    ws.send(json.dumps(payload))


if __name__ == "__main__":
    # websocket.enableTrace(True)
    env = get_env_info()
    ws = websocket.WebSocketApp(
        get_spot_ws_url(env["WS_HOST"]),
        on_open=on_open,
        on_message=on_message,
        on_error=on_error,
        on_close=on_close,
    )
    ws.run_forever()
