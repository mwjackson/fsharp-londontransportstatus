namespace LondonTransportStatus

open System

type ITubeStatus =
    abstract member Status : unit -> list<string>

type TubeStatus(tflQuery:ITflQuery, lines) =
    
    let _tflQuery = tflQuery

    let _lines = lines
    member this.Lines = _lines

    interface ITubeStatus with
        member this.Status() = 
            match(lines) with
            | [] | [""] -> []
            | _ -> 
                _tflQuery.Query()
                []
    end