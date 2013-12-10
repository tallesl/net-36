# C# base 36 encoder

A C# library to decode base 36 to base 10; encode base 10 to base 36.

## NuGet package
[nuget.org/packages/csharpbase36](http://www.nuget.org/packages/csharpbase36)

## Usage

There is simply a static class called `Base36` with an `Encode` and `Decode`methods.

### Encoding

    Base36.Encode(10);    // returns "A"
    Base36.Encode(10000); // returns "7PS"

### Decoding

    Base36.Decode("Z");   // returns 35L
    Base36.Decode("10");  // returns 36L
    Base36.Decode("7PS"); // returns 10000L

## More Info

* Negative numbers are supported.
* Case is ignored when decoding.
* Encoded from / decoded to `long` type.
* Unit tests are written to run with MSTest.

