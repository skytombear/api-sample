#!/usr/bin/env python3

import json
import requests
from requests.exceptions import HTTPError
from utils import (
    get_env_info,
    get_futures_api_version,
    get_futures_full_url,
    gen_headers,
)


# Bind take-profit / stop-loss to an existing position.
def futures_bind_tp_sl(data):
    url = "/api/{0}/order/bind/tpsl".format(get_futures_api_version())
    env = get_env_info()
    headers = gen_headers(
        env["API_KEY"], env["API_SECRET_KEY"], url, json.dumps(data)
    )
    ret = {}
    try:
        resp = requests.post(
            get_futures_full_url(env["API_HOST"], url),
            json=data,
            headers=headers,
        )
        resp.raise_for_status()
    except HTTPError as http_err:
        print("HTTP error occurred: {0}".format(http_err))
    except Exception as err:
        print("Other error occurred: {0}".format(err))
    finally:
        ret = resp.json()
    return ret


if __name__ == "__main__":
    # Set takeProfitPrice and/or stopLossPrice (at least one is required).
    data = {
        "symbol": "BTC-PERP",
        "takeProfitPrice": 31000,
        "takeProfitTrigger": "markPrice",
        "stopLossPrice": 22000,
        "stopLossTrigger": "lastPrice",
    }
    print(futures_bind_tp_sl(data))
