open System

open LondonTransportStatus

let tubefeed = "http://api.tubeupdates.com/?method=get.status&lines=tube&format=xml"
let lines = "northern"

let numRows:uint16 = uint16 5
let stationCode = "KTN"
let filterStationCode = "ZFD"
let timeOffset = 0

let ts = new TubeStatus(tubefeed)
let tubeStatus = ts.Status(lines)

for status in tubeStatus do
    Console.WriteLine(status.ToString())

let rs = new RailStatus()
let status = rs.Status(numRows, stationCode, filterStationCode, timeOffset)

let quit = Console.ReadKey()