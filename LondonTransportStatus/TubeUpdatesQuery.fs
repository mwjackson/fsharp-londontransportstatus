namespace LondonTransportStatus

open LondonTransportStatus

open System

type ITubeUpdatesQuery =
    abstract member Query : seq<string> -> string

type TubeUpdatesQuery(webRequest:IWebRequest) =

    let webRequest = webRequest

    let tubefeed = "http://api.tubeupdates.com/?method=get.status&lines=<lines>&format=xml"
    
    interface ITubeUpdatesQuery with
        member this.Query(lines) =
            let linesString = lines |> Seq.fold (fun lines line -> lines + line + ",") ""
            let url = tubefeed.Replace("<lines>", linesString.Trim(",".ToCharArray()))
            webRequest.Query(url)
            


