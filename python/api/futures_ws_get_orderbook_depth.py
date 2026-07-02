#!/usr/bin/env python3

import websocket
import json
from utils import get_env_info, get_futures_ws_url

order_counts = {}


def on_message(ws, message):
    print(message)


def on_error(ws, error):
    print(error)


def on_close(ws, close_status_code, close_msg):
    print("### socket closed ###")


def on_open(ws):
    # DEPRECATED (V2.3): the `orderBookL2Api` websocket topic has been removed.
    # L2 orderbook is now REST-only (GET /api/v2.3/orderbook/L2). For realtime
    # updates use the OSS streams instead: `update:<symbol>_<grouping>` (see
    # futures_ws_get_oss_delta.py) or `snapshotL1:<symbol>` (futures_ws_get_oss_snapshot.py).
    payload = {
        "op": "subscribe",
        "args": ["orderBookL2Api:BTC-PERP_0"],
    }
    ws.send(json.dumps(payload))


if __name__ == "__main__":
    # websocket.enableTrace(True)
    env = get_env_info()
    ws = websocket.WebSocketApp(
        get_futures_ws_url(env["WS_HOST"]),
        on_open=on_open,
        on_message=on_message,
        on_error=on_error,
        on_close=on_close,
    )
    ws.run_forever()
