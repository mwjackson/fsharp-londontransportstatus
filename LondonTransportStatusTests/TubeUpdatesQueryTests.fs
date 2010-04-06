namespace LondonTransportStatus.Tests

open LondonTransportStatus

open NUnit.Framework
open Rhino.Mocks
open System.Xml
open System

[<TestFixture>]
type TubeUpdatesQueryTests() =

    let mutable webRequest = MockRepository.GenerateStub<IWebRequest>();
    let mutable tubeUpdateQuery = new TubeUpdatesQuery(webRequest)

    [<SetUp>]
    member x.Setup() =
        webRequest <- MockRepository.GenerateStub<IWebRequest>();
        tubeUpdateQuery <- new TubeUpdatesQuery(webRequest)
    
    [<Test>]
    member x.An_updates_query_should_make_a_web_reqest() =
        let result = (tubeUpdateQuery :> ITubeUpdatesQuery).Query([])

        RhinoMocksExtensions.AssertWasCalled<IWebRequest>(webRequest, fun x -> (x :> IWebRequest).Query(Arg<string>.Is.Anything) |> ignore)

    [<Test>]
    member x.An_updates_query_should_ask_about_the_specified_lines() =
        let lines = ["northern"]
        
        let result = (tubeUpdateQuery :> ITubeUpdatesQuery).Query(lines)

        RhinoMocksExtensions.AssertWasCalled<IWebRequest>(webRequest, fun x -> (x :> IWebRequest).Query(Arg.Text.Contains(lines.Head)) |> ignore)