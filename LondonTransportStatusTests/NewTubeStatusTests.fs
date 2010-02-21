﻿namespace LondonTransportStatus.Tests

open NUnit.Framework
open Rhino.Mocks
open System.Xml
open System

type ITflQuery =
    abstract member Query : unit -> unit

type TflQuery() =
    interface ITflQuery with
        member this.Query() =
            Console.WriteLine("querying tfl")

type ITubeStatus =
    abstract member Status : unit -> list<string>

type TubeStatus(tflQuery:ITflQuery, lines) =
    
    let _tflQuery = tflQuery

    let _lines = lines
    member this.Lines = _lines

    interface ITubeStatus with
        member this.Status() = 
            match(lines) with
            | [] | [""] -> []
            | _ -> 
                _tflQuery.Query()
                []
    end

[<TestFixture>]
type TubeStatusTests ()=

    let lines = ["northern"]

    [<Test>] 
    member x.should_take_a_list_of_tube_lines() =
        let tubeStatus = new TubeStatus(new TflQuery(), lines)
        Assert.That(tubeStatus.Lines, Is.EqualTo(lines))

    [<Test>]
    member x.status_on_no_lines_should_return_empty_list() =
        let tubeStatus = new TubeStatus(new TflQuery(), [])
        let status = (tubeStatus :> ITubeStatus).Status()
        Assert.That(status, Is.EqualTo([]))

    [<Test>]
    member x.status_on_a_single_line_should_return_list_with_a_string() =
        let tubeStatus = new TubeStatus(new TflQuery(), ["aLine"])
        let status = (tubeStatus :> ITubeStatus).Status()
        Assert.That(status, Is.TypeOf(typeof<list<string>>))

    [<Test>]
    member x.status_should_query_a_tube_status_document() =
        let tflQuery = MockRepository.GenerateStub<ITflQuery>();

        let lines = ["northern"]
        let tubeStatus = new TubeStatus(tflQuery, lines)
        
        let result = (tubeStatus :> ITubeStatus).Status()

        RhinoMocksExtensions.AssertWasCalled<ITflQuery>(tflQuery, fun x -> (x :> ITflQuery).Query())
        