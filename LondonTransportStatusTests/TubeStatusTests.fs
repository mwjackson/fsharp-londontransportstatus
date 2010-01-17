namespace LondonTransportStatus.Tests

open NUnit.Framework
open FsUnit

open LondonTransportStatus

[<TestFixture>]
type ``TubeStatusTests Given a single line`` ()=

    let lines = ["northern"]
    let tubeStatus = new TubeStatus(lines)

    [<Test>] member test.
        ``TubeStatus should take a list of tube lines.`` ()=
            tubeStatus.Lines 
                |> should equal lines

[<TestFixture>]
type ``TubeStatusTests - Given a empty list`` ()=

    let lines = [""]
    let tubeStatus = new TubeStatus(lines)

    let emptyLineStatus:list<LineStatus> = []

    [<Test>] member test.
        ``Status should return empty list if lines empty.`` ()=
            tubeStatus.Status 
                |> should equal emptyLineStatus