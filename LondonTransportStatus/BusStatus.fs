namespace LondonTransportStatus

open System
open System.Net
open System.IO
open System.Xml

open HtmlAgilityPack

type BusStatus(url:string) =

    let GetStatus(routes:string) =
        let request = HttpWebRequest.Create(url)
        let response = request.GetResponse()
        let responseStream = response.GetResponseStream()
        let reader = new StreamReader(responseStream)

        let status = reader.ReadToEnd()

        let htmlDocument = new HtmlDocument()
        htmlDocument.LoadHtml(status)

        let rawBusStatus = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='news']").InnerText
        let startToken = [| "<!-- start --->" |]
        let startStatus = rawBusStatus.Split(startToken, StringSplitOptions.RemoveEmptyEntries).[1]
        let endToken = [| "<!-- end -->" |]
        let endStatus = startStatus.Split(endToken, StringSplitOptions.RemoveEmptyEntries).[0]
        let busStatus = endStatus.Trim( [| '\r'; '\n'; '\t' |] )
        busStatus

    member x.Status(routes:string) = GetStatus(routes)
