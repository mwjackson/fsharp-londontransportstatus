namespace LondonTransportStatus.Legacy

open System
open System.Net
open System.IO
open System.Xml

type Legacy_TubeStatus(lines) =
    
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
        let linesString = lines |> Seq.fold (fun lines line -> lines + line + ",") ""
        let url = tubefeed.Replace("<lines>", linesString.Trim(",".ToCharArray()))
        let request = HttpWebRequest.Create(url)
        use response = request.GetResponse()
        use responseStream = response.GetResponseStream()
        use reader = new StreamReader(responseStream)
        let status = reader.ReadToEnd()
        status
        

    let ParseStatus(status) = 
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
        | _ -> GetStatus() |> ParseStatus
