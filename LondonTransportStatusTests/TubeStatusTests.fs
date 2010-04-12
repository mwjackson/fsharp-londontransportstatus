namespace LondonTransportStatus.Tests

open LondonTransportStatus

open NUnit.Framework
open Rhino.Mocks
open System.Xml
open System

[<TestFixture>]
type TubeStatusTests ()=

    let lines = ["northern"]

    let mutable _tubeUpdatesQuery = MockRepository.GenerateStub<ITubeUpdatesQuery>();
    let mutable _tubeUpdatesConverter = MockRepository.GenerateStub<ITubeUpdatesConverter>();

    let mutable _tubeStatus = new TubeStatus(_tubeUpdatesQuery, _tubeUpdatesConverter, lines)

    [<SetUp>]
    member x.Setup() =
        _tubeUpdatesQuery <- MockRepository.GenerateStub<ITubeUpdatesQuery>();
        _tubeUpdatesConverter <- MockRepository.GenerateStub<ITubeUpdatesConverter>();

        _tubeStatus <- new TubeStatus(_tubeUpdatesQuery, _tubeUpdatesConverter, lines)


    [<Test>]
    member x.status_should_get_a_tube_update() =
        let result = (_tubeStatus :> ITubeStatus).Status()

        RhinoMocksExtensions.AssertWasCalled<ITubeUpdatesQuery>(_tubeUpdatesQuery, 
            fun x -> (x :> ITubeUpdatesQuery).Query(Arg<seq<string>>.Is.Anything) |> ignore)

    [<Test>]
    member x.status_should_parse_the_tube_update_results() =
        let result = (_tubeStatus :> ITubeStatus).Status()

        RhinoMocksExtensions.AssertWasCalled<ITubeUpdatesConverter>(_tubeUpdatesConverter, 
            fun x -> (x :> ITubeUpdatesConverter).Convert(Arg<string>.Is.Anything) |> ignore)