namespace BioFSharp.BioContainers.Tests

open Xunit

open BioFSharp.BioContainers

type BioTalkTests() =
    [<Fact>]
    let ``Kev should be greeted with 356.42`` () =
        let actual = BioTalk.helloBio "Kev"
        Assert.Equal("Hello Kev the average mass of your name as AminoAcid code is 356.42",actual)