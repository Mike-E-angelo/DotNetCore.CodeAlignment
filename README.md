# DotNetCore.CodeAlignment

This example of a [possible code alignment issue in .NET Core](https://github.com/dotnet/coreclr/issues/17932) uses the results from four different machines to demonstrate this issue.  These four machines are:

- VM Host Machine
- VM Guest
- Surface Pro 3
- Azure VM: Standard D16s v3 (16 vcpus, 64 GB memory)

The .NET Core console application found in this repository was run on each of the machines above to produce the output found below in this document. This console application is a simple Benchmark.NET benchmark runner with three cases:

1. A LINQ select calling `ToArray`.
1. An array that is filled with the same select used in the first case (courtesy of [@mikedn](https://github.com/mikedn) [[link](https://github.com/dotnet/coreclr/issues/17932#issuecomment-388008331)]).
1. Both benchmark cases defined in 1. and 2.

On all machines, the 3rd and final case that features both benchmarks demonstrates a difference in result times that deviates in some way from the results achieved in the first two benchmark cases. 

Do note that the times listed for the 3rd benchmark for the `VM Guest` are for the first run when the `BenchmarkDotNet.Artifacts` folder is not yet created.  Subsequent runs on this particular machine did match the first two times in this case.  In all other cases, the first and subsequent runs of the 3rd and final benchmark on all machines led to discrepancies.

Finally, more raw data from the results used in this document [can be found here](RawData.md).

### VM Host Machine

``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.14393.2214 (1607/AnniversaryUpdate/Redstone1)
Intel Core i7-4820K CPU 3.70GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3613273 Hz, Resolution=276.7574 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

```

#### Selection: 0

| Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
|------- |---------:|---------:|----------:|-------:|-------:|----------:|
|    Run | 18.97 us | 5.433 us | 0.3070 us | 7.6294 | 0.8240 |  39.13 KB |

#### Selection: 1

| Method |     Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
|------- |---------:|----------:|----------:|-------:|-------:|----------:|
|    Run | 18.38 us | 0.4296 us | 0.0243 us | 7.6294 | 0.8240 |  39.09 KB |

#### Selection: 2

| Method |     Mean |    Error |    StdDev | Scaled |  Gen 0 |  Gen 1 | Allocated |
|------- |---------:|---------:|----------:|-------:|-------:|-------:|----------:|
|  First | 20.84 us | 1.492 us | 0.0843 us |   1.00 | 7.6294 | 0.8240 |  39.13 KB |
| Second | 18.61 us | 1.666 us | 0.0942 us |   0.89 | 7.6294 | 0.8240 |  39.09 KB |

### VM Guest

``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-4820K CPU 3.70GHz (Haswell), 1 CPU, 8 logical and 8 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

```

#### Selection: 0

| Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
|------- |---------:|---------:|----------:|-------:|-------:|----------:|
|    Run | 18.89 us | 6.852 us | 0.3871 us | 7.6294 | 0.8240 |  39.13 KB |

#### Selection: 1

| Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
|------- |---------:|---------:|----------:|-------:|-------:|----------:|
|    Run | 18.50 us | 1.150 us | 0.0650 us | 7.6294 | 0.8240 |  39.09 KB |

#### Selection: 2

| Method |     Mean |    Error |    StdDev | Scaled |  Gen 0 |  Gen 1 | Allocated |
|------- |---------:|---------:|----------:|-------:|-------:|-------:|----------:|
|  First | 20.84 us | 1.492 us | 0.0843 us |   1.00 | 7.6294 | 0.8240 |  39.13 KB |
| Second | 18.61 us | 1.666 us | 0.0942 us |   0.89 | 7.6294 | 0.8240 |  39.09 KB |

### Surface Pro 3

```

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-4650U CPU 1.70GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
Frequency=2240907 Hz, Resolution=446.2479 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

```

#### Selection: 0

| Method |     Mean |    Error |    StdDev |   Gen 0 | Allocated |
|------- |---------:|---------:|----------:|--------:|----------:|
|    Run | 21.72 us | 2.231 us | 0.1261 us | 18.8599 |  39.13 KB |

#### Selection: 1

| Method |     Mean |    Error |    StdDev |   Gen 0 | Allocated |
|------- |---------:|---------:|----------:|--------:|----------:|
|    Run | 21.70 us | 5.389 us | 0.3045 us | 18.8599 |  39.09 KB |


#### Selection: 2

| Method |     Mean |    Error |    StdDev | Scaled |   Gen 0 | Allocated |
|------- |---------:|---------:|----------:|-------:|--------:|----------:|
|  First | 24.59 us | 2.737 us | 0.1546 us |   1.00 | 18.8599 |  39.13 KB |
| Second | 24.70 us | 5.329 us | 0.3011 us |   1.00 | 18.8599 |  39.09 KB |

### Azure VM: Standard D16s v3 (16 vcpus, 64 GB memory)

``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.248 (1709/FallCreatorsUpdate/Redstone3)
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 16 logical and 8 physical cores
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

```

#### Selection: 0

| Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
|------- |---------:|---------:|----------:|-------:|-------:|----------:|
|    Run | 28.56 us | 9.581 us | 0.5414 us | 6.2561 | 0.6714 |  39.13 KB |

#### Selection: 1

| Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
|------- |---------:|---------:|----------:|-------:|-------:|----------:|
|    Run | 28.56 us | 5.420 us | 0.3062 us | 6.2256 | 0.6714 |  39.09 KB |

#### Selection: 2

| Method |     Mean |     Error |    StdDev | Scaled | ScaledSD |  Gen 0 |  Gen 1 | Allocated |
|------- |---------:|----------:|----------:|-------:|---------:|-------:|-------:|----------:|
|  First | 33.02 us |  7.045 us | 0.3981 us |   1.00 |     0.00 | 6.1646 | 0.6714 |  39.13 KB |
| Second | 33.65 us | 15.724 us | 0.8884 us |   1.02 |     0.02 | 6.1035 | 0.6714 |  39.09 KB |