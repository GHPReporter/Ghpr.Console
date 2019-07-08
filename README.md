<p align="center">
  <a href="https://ghpreporter.github.io/"><img src="https://github.com/GHPReporter/GHPReporter.github.io/blob/master/img/logo-small.png?raw=true" alt="Project icon"></a>
  <br><br>
  <b>Some Links:</b><br>
  <a href="https://github.com/GHPReporter/Ghpr.Core">Core</a> |
  <a href="https://github.com/GHPReporter/Ghpr.MSTest">MSTest</a> |
  <a href="https://github.com/GHPReporter/Ghpr.MSTestV2">MSTestV2</a> |
  <a href="https://github.com/GHPReporter/Ghpr.NUnit">NUnit</a> |
  <a href="https://github.com/GHPReporter/Ghpr.SpecFlow">SpecFlow</a> |
  <a href="https://github.com/GHPReporter/Ghpr.Console">Console</a> |
  <a href="https://github.com/GHPReporter/GHPReporter.github.io/">Site Repo</a>
</p>

[![Build status](https://ci.appveyor.com/api/projects/status/1nhj8penho50h2ro?svg=true)](https://ci.appveyor.com/project/elv1s42/ghpr-console)
[![NuGet Version](https://img.shields.io/nuget/v/Ghpr.Console.svg)](https://www.nuget.org/packages/Ghpr.Console)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/09d98c433f034ce2ab7f4e7a655ea3f0)](https://www.codacy.com/app/GHPReporter/Ghpr.Console?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=GHPReporter/Ghpr.Console&amp;utm_campaign=Badge_Grade)
[![CodeFactor](https://www.codefactor.io/repository/github/ghpreporter/ghpr.console/badge)](https://www.codefactor.io/repository/github/ghpreporter/ghpr.console)

# Ghpr.Console

## Usage

 - download `Ghpr.Console` as Nuget package
 - make sure you have `.json` settings file in the same folder as Ghpr.Console.exe file
 - check that all dependencies exist in the `Ghpr.Console.exe` folder
 - run Ghpr.Console.exe with one or several arguments: paths to `.xml` or `.trx` files with test results
 
If your file extension is `.xml` then Ghpr.NUnit will be used to generate test results, else if the extension is `.trx` then Ghpr.MSTest will be used to generate report from file.

# Release notes

You can find it [here](https://github.com/GHPReporter/Ghpr.Core/blob/master/RELEASE_NOTES.md) for all packages.
