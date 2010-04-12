namespace LondonTransportStatus

open LondonTransportStatus

open System

type TubeLineStatus() = class end

type ITubeUpdatesConverter =
    abstract member Convert : string -> seq<TubeLineStatus>

