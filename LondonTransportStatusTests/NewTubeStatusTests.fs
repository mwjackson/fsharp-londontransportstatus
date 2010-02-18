namespace LondonTransportStatus.Tests

open NUnit.Framework
open System.Xml

type TubeStatus(lines)=

    let lines = lines
    member x.Lines = lines
    member x.Status = []

[<TestFixture>]
type TubeStatusTests ()=

    let lines = ["northern"]

    [<Test>] 
    member x.should_take_a_list_of_tube_lines() =
        let tubeStatus = new TubeStatus(lines)
        Assert.That(tubeStatus.Lines, Is.EqualTo(lines))

    [<Test>]
    member x.status_on_no_lines_should_return_empty_list() =
        let tubeStatus = new TubeStatus([])
        Assert.That(tubeStatus.Status, Is.EqualTo([]))

