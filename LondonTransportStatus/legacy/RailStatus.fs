namespace LondonTransportStatus

open System
open System.Net
open System.IO
open System.Xml

open RailServiceFacade

type RailStatus() =

    let GetStatus(rows:uint16, stationCode:string, filterStationCode:string, timeOffset:int) = 
        let filterType:FilterType = enum 1
        let client = new RailServiceFacade.LDBServiceSoapClient("LDBServiceSoap")
        let stationBoard = client.GetDepartureBoard(rows, stationCode, filterStationCode, filterType, timeOffset)
        stationBoard

    member x.Status(rows, stationCode, filterStationCode, timeOffset) = 
        GetStatus(rows, stationCode, filterStationCode, timeOffset)