namespace LondonTransportStatus

open System

type ITflQuery =
    abstract member Query : unit -> unit

type TflQuery() =
    interface ITflQuery with
        member this.Query() =
            Console.WriteLine("querying tfl")

