# .NET project template

[![Run Build and Test](https://github.com/kolosovpetro/DotnetTemplate/actions/workflows/run-build-and-test.yml/badge.svg)](https://github.com/kolosovpetro/DotnetTemplate/actions/workflows/run-build-and-test.yml)
[![Build Status](https://dev.azure.com/RazumovskyPrivateProjects/DotnetTemplate/_apis/build/status/build-dotnet-template?branchName=master)](https://dev.azure.com/RazumovskyPrivateProjects/DotnetTemplate/_build/latest?definitionId=2&branchName=master)
[![Run .NET SonarCloud analysis](https://github.com/kolosovpetro/DotnetTemplate/actions/workflows/sonar-scan.yml/badge.svg)](https://github.com/kolosovpetro/DotnetTemplate/actions/workflows/sonar-scan.yml)

This is a template for creating .NET projects with compile-time code style checking, CI/CD workflows for Github Actions
and Azure pipelines.
Also, includes SonarCloud integration.

## Nuget packages

### Compile time code style checking

- `Microsoft.CodeAnalysis.NetAnalyzers`

### Unit tests project

- `coverlet.msbuild`
- `coverlet.collector`
- `FluentAssertions`

## Required property groups in project file

```xml

<PropertyGroup>
    <EnableNETAnalyzers>true</EnableNETAnalyzers>
    <AnalysisMode>Recommended</AnalysisMode>
    <EnforceCodeStyleInBuild>true</EnforceCodeStyleInBuild>
</PropertyGroup>
```

## Commands

- `dotnet test -p:CollectCoverage=true -p:CoverletOutputFormat=opencover -p:CoverletOutput=../TestResults`
- `dotnet tool install --global dotnet-reportgenerator-globaltool --version 4.8.6`
- `reportgenerator "-reports:TestResults.opencover.xml" "-targetdir:coveragereport" -reporttypes:Html`
- `dotnet test -p:CollectCoverage=true -p:CoverletOutputFormat=opencover -p:CoverletOutput=TestResults -p:SkipAutoProps=true -p:Threshold=80`

## Sources

- [Defining formatting rules in .NET with EditorConfig](https://blog.genezini.com/p/defining-formatting-rules-in-.net-with-editorconfig)
- [Enforcing .NET code style rules at compile time](https://blog.genezini.com/p/enforcing-.net-code-style-rules-at-compile-time)
- [Analyzing and enforcing .NET code coverage with coverlet](https://blog.genezini.com/p/analyzing-and-enforcing-.net-code-coverage-with-coverlet)
- [SonarCloud via GitHub Actions](https://github.com/kolosovpetro/SonarCloudViaGithubActions)
- [How to build a .NET template and use it within Visual Studio. Part 1: Key concepts](https://www.mytechramblings.com/posts/create-dotnet-templates-for-visual-studio-part-1/)
- [How to build a .NET template and use it within Visual Studio. Part 2: Creating a template package](https://www.mytechramblings.com/posts/create-dotnet-templates-for-visual-studio-part-2/)
