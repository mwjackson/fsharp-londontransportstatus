﻿open System

Console.WriteLine("tbc")

//
//open LondonTransportStatus
//
//let lines = [ "northern"; "bakerloo"; "victoria" ]
//
//let numRows:uint16 = uint16 5
//let stationCode = "KTN"
//let filterStationCode = "ZFD"
//let timeOffset = 0
//
//let busRoutes = "C2"
//let busFeed = "http://www.tfl.gov.uk/tfl/livetravelnews/realtime/information.asp?line=" + busRoutes + "&Submit=Search&time=now&mode=buses"
//
//let ts = new TubeStatus(lines)
//let tubeStatus = ts.Status()
//
//for status in tubeStatus do
//    Console.WriteLine(status.ToString())
//
//let rs = new RailStatus()
//let railStatus = rs.Status(numRows, stationCode, filterStationCode, timeOffset)
//
//if (railStatus.trainServices <> null) then
//    for service in railStatus.trainServices do
//        Console.WriteLine(service.operator)
//        let serviceLocation = service.destination.[service.destination.Length-1]
//        Console.WriteLine(serviceLocation.locationName)
//        Console.WriteLine(service.std + " (" + service.etd + ")")
//        Console.WriteLine()
//
//let bs = new BusStatus(busFeed)
//let busStatus = bs.Status(busRoutes)
//Console.WriteLine(busStatus)
//
//let quit = Console.ReadKey()