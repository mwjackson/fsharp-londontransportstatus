namespace LondonTransportStatus

open System
open System.Net
open System.IO
open System.Xml

type IWebRequest =
    abstract member Query : string -> string

type WebRequest() =
    interface IWebRequest with
        member this.Query(url) =
            let request = HttpWebRequest.Create(url)
            use response = request.GetResponse()
            use responseStream = response.GetResponseStream()
            use reader = new StreamReader(responseStream)
            let responseString = reader.ReadToEnd()
            responseString
