namespace LondonTransportStatus

open System
open System.Net
open System.IO
open System.Xml

type TubeStatus(lines) =
    
    let lines = lines
    let tubefeed = "http://api.tubeupdates.com/?method=get.status&lines=<lines>&format=xml"

    let CreateLineStatus(node:XmlNode) =
        let name = node.SelectSingleNode("name").InnerText
        let status = node.SelectSingleNode("status").InnerText
        let messages = 
            [
                let messages = node.SelectNodes("messages/message")
                match messages.Count with
                | 0 -> yield ""
                | _ -> for message in messages do
                           yield message.InnerText
            ]
        let statustime = node.SelectSingleNode("status_requested").InnerText
        let lineStatus = new LineStatus(name, status, messages, statustime)
        lineStatus

    let GetStatus() = 
        let linesString = lines |> Seq.fold (fun lines delim -> lines + delim) ","
        let request = HttpWebRequest.Create(tubefeed.Replace("<lines>", linesString))
        let response = request.GetResponse()
        let responseStream = response.GetResponseStream()
        let reader = new StreamReader(responseStream)

        let status = reader.ReadToEnd()

        let doc = new XmlDocument()
        doc.LoadXml(status)

        let xmlStatuses =
            [
                for node in doc.SelectNodes("response/lines/line") do
                    yield CreateLineStatus(node)
            ]
        xmlStatuses
 
    member x.Lines() = lines
    member x.Status() = 
        match lines with
        | [] -> []
        | [""] -> []
        | _ -> GetStatus()
