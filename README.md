<p align="center">
    <a href="#36">
        <img alt="logo" src="Assets/logo-200x200.png">
    </a>
</p>

# 36

[![][build-img]][build]
[![][nuget-img]][nuget]

Encodes [base 10] to [base 36] and decodes [base 36] to [base 10].

[build]:     https://ci.appveyor.com/project/TallesL/net-36
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/net-36?svg=true
[nuget]:     https://www.nuget.org/packages/36
[nuget-img]: https://badge.fury.io/nu/36.svg
[base 36]:   https://en.wikipedia.org/wiki/Base36
[base 10]:   https://en.wikipedia.org/wiki/Decimal

## Usage

```cs
using Base36Library;

// Encoding
Base36.Encode(10);    // returns "A"
Base36.Encode(10000); // returns "7PS"

// Decoding
Base36.Decode("Z");   // returns 35L
Base36.Decode("10");  // returns 36L
Base36.Decode("7PS"); // returns 10000L
```