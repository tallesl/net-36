# C# base 36 encoder

A C# library that decodes base 36 → base 10 and encodes base 10 → base 36.

## Usage

There is simply a static class called `Base36` with an `Encode` and `Decode`methods.

### Encoding

```cs
Base36.Encode(10);    // returns "A"
Base36.Encode(10000); // returns "7PS"
```

### Decoding

```cs
Base36.Decode("Z");   // returns 35L
Base36.Decode("10");  // returns 36L
Base36.Decode("7PS"); // returns 10000L
```

## More Info

* Negative numbers are supported;
* Case is ignored when decoding;
* Encoded from / decoded to `long` type;
* Unit tests are written to run with MSTest;
* There's a [NuGet package](http://www.nuget.org/packages/csharpbase36).

