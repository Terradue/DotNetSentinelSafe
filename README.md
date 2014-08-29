[![Build Status](https://build.terradue.com/buildStatus/icon?job=DotNetSentinelSafe)](https://build.terradue.com/job/DotNetSentinelSafe/)

# DotNetSentinelSafe - .Net library and tools to manipulate Sentinel product and metadata in SAFE format

Terradue.Sentinel.Safe is a library targeting .NET 4.0 and above providing an easy way to to manipulate Sentinel product and metadata in SAFE format.

Sentinel SAFE Specification: http://docs.opennebula.org/4.6/integration/system_interfaces/api.html

## Usage examples

```c#
// Deserialize the product metadata annotation
l1ProductType product = l1ProductType.FromAnnotationXml("../Terradue/Sentinel/Safe/Sar/Samples/rs2-iw1-slc-hh-20130426t045831-20130426t045914-001771-000001-001.xml");
// print product start date
Console.WriteLine(product.adsHeader.startTime.ToString("yyyy-MM-ddThh:mm:ss.fffZ"));

```

## Supported Platforms

* .NET 4.0 (Desktop / Server)
* Xamarin.iOS / Xamarin.Android / Xamarin.Mac
* Mono 2.10+

## Getting Started

Terradue.Sentinel.Safe is available as NuGet package in releases.

```
Install-Package Terradue.Sentinel.Safe
```

## Build

Terradue.Sentinel.Safe is a single assembly designed to be easily deployed anywhere. 

To compile it yourself, you’ll need:

* Visual Studio 2012 or later, or Xamarin Studio

To clone it locally click the "Clone in Desktop" button above or run the 
following git commands.

```
git clone git@github.com:Terradue/DotNetSentinelSafe.git DotNetSentinelSafe
```

## TODO

* Other metadata
* Other levels

## Copyright and License

Copyright (c) 2014 Terradue

Licensed under the [GPL v2 License](https://github.com/Terradue/DotNetSentinelSafe/blob/master/LICENSE)

### Questions, bugs, and suggestions

Please file any bugs or questions as [issues](https://github.com/Terradue/DotNetSentinelSafe/issues/new) 

### Want to contribute?

Fork the repository [here](https://github.com/Terradue/DotNetSentinelSafe/fork) and send us pull requests.

