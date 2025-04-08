module ProjectInfo

open Fake.Core


let project = "BioFSharp.BioContainers"

let testProjects = 
    [
        "tests/BioFSharp.BioContainers.Tests/BioFSharp.BioContainers.Tests.fsproj"
    ]

let solutionFile  = $"{project}.sln"

let configuration = "Release"

let gitOwner = "BioFSharp"

let gitHome = $"https://github.com/{gitOwner}"

let projectRepo = $"https://github.com/{gitOwner}/{project}"

let pkgDir = "pkg"


// Create RELEASE_NOTES.md if not existing. Or "release" would throw an error.
Fake.Extensions.Release.ReleaseNotes.ensure()

let release = ReleaseNotes.load "RELEASE_NOTES.md"

let stableVersion = SemVer.parse release.NugetVersion

let stableVersionTag = (sprintf "%i.%i.%i" stableVersion.Major stableVersion.Minor stableVersion.Patch )

let mutable prereleaseSuffix = ""

let mutable prereleaseTag = ""

let mutable isPrerelease = false

