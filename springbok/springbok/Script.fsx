#load "springbok.fs"
open System

#r "../../packages/FSharp.Data/lib/net45/FSharp.Data.dll"
open FSharp.Data

let url = "https://api.mybitx.com/api/1/ticker?pair=XBTZAR"

type TickerPair = JsonProvider<"""{"timestamp":1518119215462,"bid":"105499.00","ask":"105500.00","last_trade":"105499.00","rolling_24_hour_volume":"991.43949","pair":"XBTZAR"}""">

let tickerNow = TickerPair.Load(url)

let timeNow = System.DateTimeOffset.FromUnixTimeMilliseconds(tickerNow.Timestamp).UtcDateTime