open System

open LondonTransportStatus

let lines = "northern"

let tubefeed = "http://api.tubeupdates.com/?method=get.status&lines=" + lines + "&format=xml"

let numRows:uint16 = uint16 5
let stationCode = "KTN"
let filterStationCode = "ZFD"
let timeOffset = 0

let ts = new TubeStatus(tubefeed)
let tubeStatus = ts.Status(lines)

for status in tubeStatus do
    Console.WriteLine(status.ToString())

let rs = new RailStatus()
let railStatus = rs.Status(numRows, stationCode, filterStationCode, timeOffset)

for service in railStatus.trainServices do
    Console.WriteLine(service.operator)
    let serviceLocation = service.destination.[service.destination.Length-1]
    Console.WriteLine(serviceLocation.locationName)
    Console.WriteLine(service.std + " (" + service.etd + ")")
    Console.WriteLine()

let quit = Console.ReadKey()