# BioFSharp.BioContainers

![Logo](docs/img/Logo_large.png)

A template repository for creating an extension package for BioFSharp.

## Development

### General

BioFSharp repositories usually folllow this structure:

```
root
│   📄<project name>.sln
│   📄build.cmd
│   📄build.sh
├───📁build
├───📁docs
├───📁src
|   └───📁<project name>
└───tests
    └───📁<testproject name>
```

- <project name>.sln is the root solution file.
- `build` contains a [FAKE](https://fake.build/) build project with targets for building, testing and packaging the project.
- `build/sh` and `build.cmd` in the root are shorthand scripts to execute the buildproject.
- `docs` contains the documentation in form of literate scripts and notebooks. 
- `src` contains folders with the source code of the project(s).
- `tests` contains folders with test projects.

### Build

just call `build.sh` or `build.cmd` depending on your OS.

### Test

```bash
build.sh runtests
```

```bash
build.cmd runtests
```

### Create Nuget package

```bash
build.sh pack
```
```bash
build.cmd pack
```

### Docs

You can watch locally with hot reload via

```bash
build.sh watchdocs
```
```bash
build.cmd watchdocs
```