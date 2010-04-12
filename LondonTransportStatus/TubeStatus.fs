namespace LondonTransportStatus

open System

type ITubeStatus =
    abstract member Status : unit -> seq<TubeLineStatus>

type TubeStatus(tubeQuery:ITubeUpdatesQuery, tubeUpdatesConverter:ITubeUpdatesConverter, lines) =
    
    let _tubeQuery = tubeQuery
    let _tubeUpdatesConverter = tubeUpdatesConverter

    let _lines = lines
    member this.Lines = _lines

    interface ITubeStatus with
        member this.Status() = 
            match(lines) with
            | [] | [""] -> Seq.empty
            | _ -> _tubeQuery.Query(lines) |> _tubeUpdatesConverter.Convert
    end