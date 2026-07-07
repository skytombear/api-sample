# BTSE API Connectors
Sample connectors for connecting to the BTSE API.

## Refer to the official API documentation located at:

* [Spot](https://btsecom.github.io/docs/spot/en/#change-log)
* [Futures](https://btsecom.github.io/docs/futures/en/#change-log)
* [OTC](https://btsecom.github.io/docs/otc/en/#change-log)
* [Wallet/Convert/Transfer](https://btsecom.github.io/docs/wallet/en/#change-log)
* [Streaming](https://btsecom.github.io/docs/streaming/en/#change-log)
* [Earn](https://btsecom.github.io/docs/earn/en/#change-log)

## Change Log

* 2026-07-07
  - Update **Postman** collection to match the current sample coverage and the v3.3 / v2.3 docs.
    - Bump Spot API version `v3.2` -> `v3.3` and Futures `v2.1` -> `v2.3` (Wallet stays `v3.2`, OTC stays `v1`).
    - Update Futures order examples to the `BTC-PERP` symbol format.
    - Rename the mislabelled Spot `create-peg-order` (its body was a plain LIMIT order) to `create-limit-order`, and add a real `create-peg-order`.
    - Add the full set of Create Order examples per the docs:
      - Spot: MARKET, MARKET STOP, MARKET TAKE PROFIT, LIMIT STOP, OCO, TRAILING STOP, PEG.
      - Futures: MARKET, LIMIT TRIGGER, LIMIT STOP, OCO, reduce-only, TP/SL (plus TP-only / SL-only), hedge-mode MARKET, TRAILING STOP.
    - Trailing/stop trailing orders include the `trailValueType` field required by the live venue (not documented).

* 2026-07-02
  - Update **Spot** samples to API v3.3 across Python / Node.js / C#.
    - Bump spot API version `v3.2` -> `v3.3` (symbols already `BTC-USD`).
    - Fix bugs: Python orderbook L2 path (`/orderbook/L2`) & drop bogus `includeOld`; Node `amend-order` `slide` field & `tradeHistory`->`tradeHistoryApi` topic; C# `SpotQueryMarketPrice` wrongly using the futures version/host.
    - Update websocket topics: `notificationApiV2/V1` -> `notificationApiV3`, `snapshot` -> `snapshotL1` (drop grouping); mark removed `orderBookApi` topic deprecated.
    - Update C# make/cancel response entities to the v3.3 base/quote fields (`originalOrderBaseSize`/`QuoteSize`, `currentOrderBaseSize`/`QuoteSize`, `remainingOrderBaseSize`/`QuoteSize`, `filledBaseSize`, `totalFilledBaseSize`, `orderCurrency`).
    - Add missing samples for full three-language parity: single Query Order, and a C# project per remaining spot endpoint (Public / Trade / Investment / Websocket).

* 2026-07-01
  - Update Futures **Python** samples to API v2.3.
    - Bump futures API version `v2.1` -> `v2.3`; update market symbols to the `BTC-PERP` format.
    - Fix existing samples: orderbook L2 path (`/orderbook/L2`), risk limit field (`riskLimitLevel`), account fees request, wallet transfer path (`/user/wallet/transfer`), OCO order, charting `resolution`, trades `includeOld`.
    - Update websocket topics (`notificationApiV4`, `allPositionV4`, `fillsV2`, `tradeHistoryApiV3`, `snapshotL1`).
    - Add new endpoint samples: Query Order, Get Risk Limit, Get Leverage, Bind TP/SL, Query/Change Position Mode, Query Margin, Funding History, Market Risk Limit Setting, Query Unified Wallet Margin, Sub-account Wallet Transfer, and the `positionsV3` websocket.
  - Update Futures **Node.js** samples to API v2.3 (same scope as Python: version bump, BTC-PERP symbols, bug fixes, websocket topics, and new endpoint samples incl. the positionsV3 websocket).
  - Update Futures **C#** samples to API v2.3: bump `FuturesApiVersion` to v2.3, BTC-PERP symbols, fix the make/cancel response entities (originalOrderSize/currentOrderSize/filledSize/totalFilledSize, avgFilledPrice), and add a project per remaining endpoint (Public/Trade/Wallet/Websocket incl. positionsV3) so C# reaches full futures coverage.
  - Update dependency versions to current stable (Python 3.13, Node.js 24 LTS, .NET 10) and migrate the Node.js ESLint config to flat config.

* 2023-10-05
  - Add .NET6 sample code.

* 2023-09-27
  - Remove the btse wording

* 2023-09-23
  - Add dotenv package for Nodejs.
  - Add example in README for running without docker

* 2022-09-14
  - Add examples to create oco futures order

* 2023-09-07
  - Replace the variable names `staging-url` and `dev-url` with `api-url` in Postman collection.
  - Add Testnet environment file in Postman folder.
  - Add steps for importing the environment file in the Postman README.

* 2023-08-31
  - Update sign header from btse-* to request-*

* 2022-08-19
  - Add examples to get order status via notification v2 websocket topic

* 2022-06-28
  - Add examples to query futures trade history

* 2022-04-09
  - Add python example to delete multiple orders

* 2022-03-30
  - Add nodejs sample to get all futures position via `allPosition` websocket topic

* 2022-03-24
  - Add python and js samples for oss delta orderbook
    - `nodejs -> app -> spot -> ws-oss-delta.js`
    - `nodejs -> app -> spot -> ws-oss-snapshot.js`
    - `python -> api -> spot_ws_get_oss_delta.py`
    - `python -> api -> spot_ws_get_oss_snapshot.py`

* 2022-02-18
  - Add more examples for `amend order` and others

* 2022-02-02
  - Futures settle_in sample to change settlement currency

* 2022-01-25
  - Add nodejs example for `fetch wallet convert rate` and `otc partial transact`

* 2022-01-18
  - Add python docker environment and adjust file structure

* 2022-01-13
  - Add examples for wallet convert and transfer

* 2022-01-10
  - Update Nodejs orderbook delta examples

* 2021-12-27
  - Update Python and Nodejs examples

## Examples

  * API version
    - Spot: v3.3
    - Futures: v2.3
    - Otc: v1


* [Python](https://github.com/btsecom/api-sample/tree/master/python)

  * How to play with python examples with docker
    1. Run `cp config/.env.example python/.env` and fill-in needed data in `.env`
    1. Set `python` as your current working directory
    1. `make api-sample-python` to build the runtime environment docker image
    1. `make run {{EXAMPLE_FILE}}` to run the example within docker container, for example: `make run api/spot_get_wallet_balance.py`

  * How to play with python examples without docker
    1. Run `cp config/.env.example python/.env` and fill-in needed data in `.env`
    1. Set `python` as your current working directory
    1. install Python (version >= 3.13)
    1. install package by poetry
    1. `python run {{EXAMPLE_FILE}}` to run the example, for example: `python api/spot_get_wallet_balance.py`


* [Nodejs](https://github.com/btsecom/api-sample/tree/master/nodejs)

  * How to play with node examples with docker
    1. Run `cp config/.env.example nodejs/.env` and fill-in needed data in `.env`
    1. Set `nodejs` as your current working directory
    1. `make api-sample-nodejs` to build the runtime environment docker image
    1. `make run {{EXAMPLE_FILE}}` to run the example within docker container, for example: `make run app/spot/query-market-summary.js`

  * How to play with node examples without docker
    1. Run `cp config/.env.example nodejs/.env` and fill-in needed data in `.env`
    1. Set `nodejs` as your current working directory
    1. install Nodejs (version >= 20, LTS 24 recommended)
    1. `npm install` to install required packages
    1. `node {{EXAMPLE_FILE}}` to run the example, for example: `node app/spot/query-market-summary.js`

* [C#](https://github.com/btsecom/api-sample/tree/master/CSharp/BTSEApiSample)

  * How to play with C# examples without docker
    1. Run `cp config/.env.example CSharp/BTSEApiSample/BTSEApiSample/.env` and fill-in needed data in `.env`
    1. Install .NET10 SDK. You can find download link [here](https://dotnet.microsoft.com/en-us/download/dotnet/10.0).
    1. Open `CSharp/BTSEApiSample/BTSEApiSample.sln` with Visual Studio.
    1. Run the project you want to test with Visual Studio.

# Files Comparison
## Earn
### Investment Endpoints
|Document Name |Python |
| :--------   | :--------   |
|Deposit Investment |earn_buy_product.py |
|Query Investment History |earn_get_history.py |
|Query Investment Orders |earn_get_orders.py |
|Query Investment Products |earn_get_products.py |
|Redeem Investment |earn_redeem_product.py |
|Renew Investment |earn_renew_product.py |
<br>

## Futures
### Public Endpoints
|Document Name |Python |Node.js |C# (project) |
| :--------   | :--------   | :--------   | :--------   |
|Market Summary |futures_get_market_summary.py |market-summary.js |FutureMarketSummaryProject |
|Charting Data |futures_charting_data.py |charting-data.js |FutureChartingDataProject |
|Query Market price | futures_query_market_price.py |query-market-price.js |FutureQueryMarketPriceProject |
|Orderbook (By grouping) |futures_get_orderbook.py |orderbook-grouping.js |FutureOrderbookProject |
|Orderbook |futures_get_orderbook_L2.py |orderbook-L2.js |FutureOrderbookL2Project |
|Query Trades Fills |futures_get_trades.py |query-trade-fills.js |FutureQueryTradesProject |
|Funding History |futures_get_funding_history.py |funding-history.js |FutureFundingHistoryProject |
|Market Risk Limit Setting |futures_get_market_risk_limit.py |market-risk-limit.js |FutureMarketRiskLimitProject |

### Trade Endpoints
|Document Name |Python |Node.js |C# (project) |
| :--------   | :--------   | :--------   | :--------   |
|Create new order |futures_place_limit_order.py |create-limit-order.js |FutureMakeOrderProject |
|Create new algo order|futures_create_new_algo_order.py|create-algo-order.js|FutureCreateAlgoOrderProject|
|Amend Order |futures_amend_order.py |amend-order.js |FutureAmendOrderProject |
|Cancel Order |futures_cancel_order.py |cancel-order.js |FutureCancelOrderProject |
|Query Order |futures_query_order.py |query-order.js |FutureQueryOrderProject |
|Dead man's switch (Cancel all after)|futures_cancel_all_after.py|cancel-all-after.js|FutureCancelAllAfterProject|
|Query Open Orders |futures_get_open_orders.py |query-open-orders.js |FutureQueryOpenOrdersProject |
|Query Trades Fills|futures_query_trades_fills.py|query-trade-history.js|FutureQueryTradeHistoryProject|
|Query Position|futures_query_position.py|query-positions.js|FutureQueryPositionProject|
|Close Position|futures_close_position.py|close-position.js|FutureClosePositionProject|
|Get Risk Limit|futures_get_risk_limit.py|get-risk-limit.js|FutureGetRiskLimitProject|
|Set Risk Limit|futures_set_risk_limits.py|set-risk-limit.js|FutureSetRiskLimitProject|
|Set Leverage|futures_set_leverage.py|set-leverage.js|FutureSetLeverageProject|
|Get Leverage|futures_get_leverage.py|get-leverage.js|FutureGetLeverageProject|
|Change contract settlement currency|futures_change_settlement_currency.py |change-settlement-currency.js |FutureChangeSettlementProject |
|Query Account Fees|futures_query_account_fees.py|query-account-fees.js|FutureQueryAccountFeesProject|
|Bind TP/SL|futures_bind_tp_sl.py|bind-tp-sl.js|FutureBindTpSlProject|
|Query Position Mode|futures_query_position_mode.py|query-position-mode.js|FutureQueryPositionModeProject|
|Change Position Mode|futures_change_position_mode.py|change-position-mode.js|FutureChangePositionModeProject|
|Query Margin Percentage|futures_query_margin_setting.py|query-margin-setting.js|FutureQueryMarginSettingProject|

### Wallet Endpoints
|Document Name |Python |Node.js |C# (project) |
| :--------   | :--------   | :--------   | :--------   |
|Query Wallet Balance|futures_query_wallet_balance.py|query-wallet-balance.js|FutureQueryWalletBalanceProject|
|Query Wallet History | futures_query_wallet_history.py |query-wallet-history.js |FutureQueryWalletHistoryProject |
|Query Wallet Margin|futures_query_wallet_margin.py|query-wallet-margin.js|FutureQueryWalletMarginProject|
|Query Unified Wallet Margin|futures_query_unified_wallet_margin.py|query-unified-wallet-margin.js|FutureQueryUnifiedWalletMarginProject|
|Transfer funds between Futures wallet|futures_transfer_funds_between_futures_wallet.py|-|FutureTransferFundsProject|
|Sub-account Wallet Transfer|futures_subaccount_wallet_transfer.py|subaccount-wallet-transfer.js|FutureSubAccountTransferProject|

### Websocket Streams
|Document Name |Python |Node.js |C# (project) |
| :--------   | :--------   | :--------   | :--------   |
|Subscription|futures_ws_subscription.py |-|FutureWsSubscriptionProject|
|Orderbook Snapshot (By grouping)|futures_ws_get_orderbook_group.py |-|-|
|Orderbook Snapshot (By depth)|futures_ws_get_orderbook_depth.py|-|-|
|Orderbook Incremental Updates|futures_ws_get_oss_delta.py|ws-get-orderbook-delta.js|FutureWsOrderbookDeltaProject|
|Orderbook BBO Snapshot (snapshotL1)|futures_ws_get_oss_snapshot.py|-|FutureWsOrderbookSnapshotProject|
|Public Trade Fills|futures_ws_public_trade_fills.py|ws-public-trades.js|FutureWsPublicTradeFillsProject|
|Authentication|futures_ws_authentication.py|-|FuturesWsAuthenticationProject|
|Notifications|futures_ws_notifcations.py|ws-notification-v2.js|FutureWsNotificationsProject|
|User Trade Fills|futures_ws_user_trade_fillls.py|-|FutureWsUserTradeFillsProject|
|All Position|futures_ws_get_all_position.py|ws-get-all-position.js|FutureWsAllPositionProject|
|Positions|futures_ws_get_positions.py|ws-get-positions.js|FutureWsPositionsProject|

## Spot
### Public Endpoints
|Document Name |Python |Node.js |C# (project) |
| :--------   | :--------   | :--------   | :--------   |
|Market Summary|spot_get_market_summary.py|query-market-summary.js|SpotMarketSummaryProject|
|Charting Data|spot_get_ohlcv.py|charting-data.js|SpotChartingDataProject|
|Query Market Price|spot_get_price.py|query-market-price.js|SpotQueryMarketPriceProject|
|Orderbook (By grouping)|spot_get_orderbook.py|orderbook-grouping.js|SpotOrderbookProject|
|Orderbook|spot_get_orderbook_L2.py|orderbook-L2.js|SpotOrderbookL2Project|
|Query Trades Fills|spot_get_trades.py|query-trade-fills.js|SpotQueryTradesProject|
|Query Server Time|spot_get_time.py|query-server-time.js|SpotQueryServerTimeProject|

### Trade Endpoints
|Document Name |Python |Node.js |C# (project) |
| :--------   | :--------   | :--------   | :--------   |
|Create New Order|spot_post_place_order.py|create-limit-order.js|SpotMakeOrderProject|
|Create New Algo Order|spot_post_place_order.py|create-peg-order.js|SpotCreateAlgoOrderProject|
|Query Order|spot_get_order.py|query-order.js|SpotQueryOrderProject|
|Amend Order|spot_amend_order.py|amend-order.js|SpotAmendOrderProject|
|Cancel Order|spot_cancel_multiple_orders.py|cancel-order.js|SpotCancelOrderProject|
|Dead man's switch (Cancel all after)|spot_cancel_all_after.py|cancel-all-orders.js|SpotCancelAllAfterProject|
|Query Open Orders|spot_get_open_orders.py|query-open-orders.js|SpotQueryOpenOrdersProject|
|Query User Trades Fills|spot_get_trade_history.py|query-trade-history.js|SpotQueryTradeHistoryProject|
|Query Account Fees|spot_get_user_fees.py|query-account-fees.js|SpotQueryAccountFeesProject|

### Investment Endpoints
|Document Name |Python |Node.js |C# (project) |
| :--------   | :--------   | :--------   | :--------   |
|Query Investment Products|spot_get_invest_products.py|earn/query-investment-products.js|SpotInvestProductsProject|
|Deposit Investment|spot_post_invest_deposit.py|earn/deposit-investment.js|SpotInvestDepositProject|
|Renew Investment|spot_post_invest_renew.py|earn/renew-investment.js|SpotInvestRenewProject|
|Redeem Investment|spot_post_invest_redeem.py|earn/investment-redeem.js|SpotInvestRedeemProject|
|Query Investment Orders|spot_get_invest_orders.py|earn/investment-orders.js|SpotInvestOrdersProject|
|Query Investment History|spot_get_invest_history.py|earn/investment-history.js|SpotInvestHistoryProject|

### Websocket Streams
|Document Name |Python |Node.js |C# (project) |
| :--------   | :--------   | :--------   | :--------   |
|Ping/Pong|spot_ws_ping_pong.py|ws-ping-pong.js|SpotWsPingPongProject|
|Subscription|-|-|SpotWsSubscriptionProject|
|Public Trade Fills|spot_ws_public_trade_fills.py|ws-trade-history.js|SpotWsPublicTradeFillsProject|
|Authentication|-|-|SpotWsAuthenticationProject|
|Notifications|spot_ws_notification_v2_create_limit_order.py|ws-notification-v2.js|SpotWsNotificationsProject|
|User Trade Fills|spot_ws_trade_fills.py|ws-user-fills.js|SpotWsUserTradeFillsProject|
|OSS BBO Snapshot (snapshotL1)|spot_ws_get_oss_snapshot.py|ws-oss-snapshot.js|SpotWsOrderbookSnapshotProject|
|OSS Incremental Updates (update)|spot_ws_get_oss_delta.py|ws-oss-delta.js|SpotWsOrderbookDeltaProject|

## OTC
### OTC Endpoints
|Document Name |Python |
| :--------   | :--------   |
|Market Summary|otc_get_market_summary.py|
|Request for Quote|otc_get_quote.py|
|Accept Quote|otc_accept_quote.py|
|Query Order||

### Websocket Streams
|Document Name |Python |
| :--------   | :--------   |
|Authentication|otc_ws_authentication.py|
|Quote Stream|otc_ws_quote_stream.py|

## Streaming
### Workflow
|Document Name |Python |
| :--------   | :--------   |
|Streaming OTC|streaming_otc.py|

### Websocket Streams
|Document Name |Python |
| :--------   | :--------   |
|Authentication|otc_ws_authentication.py|
|Quote Stream|otc_ws_quote_stream.py|

## wallet/Convert/Transfer
### Public Endpoints
|Document Name |Python |
| :--------   | :--------   |
|Query available crypto network list for currency|queryAvailableCrypo.py|
|Query exchange rate between assets|queryExchangeRate.py|

### Wallet Endpoints
|Document Name |Python |
| :--------   | :--------   |
|Query Wallet Balance|queryWalletBalance.py|
|Query Wallet History|WalletqueryWalletHistory.py|
|Query available currency list for wallet action|queryAvailableCurrency.py|
|Convert funds|WalletConvertFunds.py|
|Transfer funds|WalletTransferFunds.py|
