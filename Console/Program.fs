open System

open LondonTransportStatus

let feed = "http://api.tubeupdates.com/?method=get.status&lines=tube&format=xml"
let lines = "northern"

let ts = new TubeStatus(feed)
let statuses = ts.Status(lines)

for status in statuses do
    Console.WriteLine(status.ToString())

let quit = Console.ReadKey()