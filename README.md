# C# Parameterless Struct Test

[![Unlicense Licensed](https://img.shields.io/github/license/pathogenplayground/csharpparameterlessstruct?style=flat-square)](LICENSE.txt)
[![Sponsor](https://img.shields.io/badge/sponsor-%E2%9D%A4-lightgrey?logo=github&style=flat-square)](https://github.com/sponsors/PathogenDavid)

This repository demonstrates using a struct with a parameterless constructor (written in IL) from C#.

It also seves as a quick test that [dotnet/runtime#6536](https://github.com/dotnet/runtime/issues/6536) was fixed.

The expected output is:

```
=====================================================================
Defaulted struct.
Hello, world!
Initialized from parameterless constructor.
Initialized from parameterless constructor.
Initialized from parameterless constructor.
=====================================================================
```

To build and run the example on Windows, simply run `BuildAndRun.cmd`. Currently requires Visual Studio 2019 and .NET 5, but those aren't inherent requirements.

## License

This project is licensed under The Unlicense license. [See the license file for details](LICENSE.txt).
