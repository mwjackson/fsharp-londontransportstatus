namespace LondonTransportStatus

open System
open System.Net
open System.IO
open System.Xml

type LineStatus(name:string, status:string, messages:seq<string>, statustime:string) =

    override this.ToString() = 
        let messageString = messages |> Seq.fold(fun m1 m2 -> m1 + m2 + Environment.NewLine) ""
        let result = "Name:" + name + Environment.NewLine 
                    + "Status: " + status + Environment.NewLine 
                    + "Messages: " + messageString
                    + "StatusTime: " + statustime + Environment.NewLine
        result

    member this.Name = name
    member this.Status = status
    member this.Messages = messages
    member this.StatusTime = statustime
