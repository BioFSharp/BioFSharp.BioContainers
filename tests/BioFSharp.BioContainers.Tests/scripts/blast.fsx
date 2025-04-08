#r "nuget: Docker.DotNet, 3.125.2"
#r "nuget: SharpZipLib, 1.4.2"
#r "nuget: FSharpAux, 2.0.0"
#r "nuget: FSharpAux.IO, 2.0.0"

#I "../../../src/BioFSharp.BioContainers/bin/Debug/netstandard2.0"
#r "BioFSharp.BioContainers.dll"

open System.Threading
open System.Threading
open Docker.DotNet
open System.Threading
open System.Buffers
open System.Threading.Tasks

open BioFSharp.BioContainers
open System.Collections.Generic
open Docker.DotNet.Models
open System.IO

open ICSharpCode.SharpZipLib.GZip
open ICSharpCode.SharpZipLib.Tar
open Newtonsoft.Json.Serialization
open System

let client = Docker.connect "npipe://./pipe/docker_engine"

Docker.Image.listImages client