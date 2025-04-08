// test scripts for docker functionality. Port to a test project eventually, but ber awayre that this will most likely never run in any CI.
#r "nuget: Docker.DotNet, 3.125.15"
#r "nuget: SharpZipLib, 1.4.2"
#r "nuget: FSharpAux, 2.0.0"
#r "nuget: FSharpAux.IO, 2.0.0"

//#I "../../../src/BioFSharp.BioContainers/bin/Debug/netstandard2.0"
//#r "BioFSharp.BioContainers.dll"

//open BioFSharp.BioContainers
open Docker.DotNet

let connect (str: string) =
    (new DockerClientConfiguration(new Uri(str)) ).CreateClient()

let connection = Docker.connect "npipe://./pipe/docker_engine"

// Images

let p = new ImagesListParameters()
connection.Images.ListImagesAsync()