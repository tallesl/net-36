# [![logo](logo/83x22.png)](#c-base-36-encoder) C# base 36 encoder

[![nuget package](https://badge.fury.io/nu/csharpbase36.png)](http://badge.fury.io/nu/csharpbase36)

A C# library that decodes base 36 → base 10 and encodes base 10 → base 36.

## Usage

```cs
// Encoding
Base36.Encode(10);    // returns "A"
Base36.Encode(10000); // returns "7PS"

// Decoding
Base36.Decode("Z");   // returns 35L
Base36.Decode("10");  // returns 36L
Base36.Decode("7PS"); // returns 10000L
```

## More

* Negative numbers are supported;
* Case is ignored when decoding;
* The `long` type is used both when encoding and decoding;
* Unit tests written with MSTest;
* There is a [NuGet package](http://www.nuget.org/packages/csharpbase36).