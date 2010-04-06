namespace LondonTransportStatus.Tests

open LondonTransportStatus

open NUnit.Framework
open Rhino.Mocks
open System.Xml
open System

[<TestFixture>]
type TubeStatusTests ()=

    let lines = ["northern"]

    [<Test>]
    member x.status_should_get_a_tube_update() =
        let tflQuery = MockRepository.GenerateStub<ITubeUpdatesQuery>();

        let lines = ["northern"]
        let tubeStatus = new TubeStatus(tflQuery, lines)
        
        let result = (tubeStatus :> ITubeStatus).Status()

        RhinoMocksExtensions.AssertWasCalled<ITubeUpdatesQuery>(tflQuery, 
            fun x -> (x :> ITubeUpdatesQuery).Query(Arg<seq<string>>.Is.Anything) |> ignore)