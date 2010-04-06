namespace LondonTransportStatus

open System

type ITubeStatus =
    abstract member Status : unit -> list<string>

type TubeStatus(tubeQuery:ITubeUpdatesQuery, lines) =
    
    let _tubeQuery = tubeQuery

    let _lines = lines
    member this.Lines = _lines

    interface ITubeStatus with
        member this.Status() = 
            match(lines) with
            | [] | [""] -> []
            | _ -> 
                tubeQuery.Query([]) |> ignore
                []
    end