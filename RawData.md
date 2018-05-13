# Raw Data

This page features the extended data from each machine run.

### VM Host Machine

```
// * Detailed results *
First.Run: Job-ZYOSFD(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 18.9737 us, StdErr = 0.1772 us (0.93%); N = 3, StdDev = 0.3070 us
Min = 18.7588 us, Q1 = 18.7588 us, Median = 18.8370 us, Q3 = 19.3252 us, Max = 19.3252 us
IQR = 0.5665 us, LowerFence = 17.9091 us, UpperFence = 20.1749 us
ConfidenceInterval = [13.5406 us; 24.4067 us] (CI 99.9%), Margin = 5.4330 us (28.63% of Mean)
Skewness = 0.36, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[18.610 us ; 19.511 us) | @@@
---------------------------------------------------

Total time: 00:00:05 (5.98 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.14393.2214 (1607/AnniversaryUpdate/Redstone1)
Intel Core i7-4820K CPU 3.70GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3613273 Hz, Resolution=276.7574 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
------- |---------:|---------:|----------:|-------:|-------:|----------:|
	Run | 18.97 us | 5.433 us | 0.3070 us | 7.6294 | 0.8240 |  39.13 KB |
	
===============================================

// * Detailed results *
Second.Run: Job-YZCALH(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 18.3808 us, StdErr = 0.0140 us (0.08%); N = 3, StdDev = 0.0243 us
Min = 18.3537 us, Q1 = 18.3537 us, Median = 18.3880 us, Q3 = 18.4006 us, Max = 18.4006 us
IQR = 0.0469 us, LowerFence = 18.2833 us, UpperFence = 18.4709 us
ConfidenceInterval = [17.9512 us; 18.8103 us] (CI 99.9%), Margin = 0.4296 us (2.34% of Mean)
Skewness = -0.27, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[18.339 us ; 18.415 us) | @@@
---------------------------------------------------

Total time: 00:00:05 (5.9 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.14393.2214 (1607/AnniversaryUpdate/Redstone1)
Intel Core i7-4820K CPU 3.70GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3613273 Hz, Resolution=276.7574 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
------- |---------:|----------:|----------:|-------:|-------:|----------:|
	Run | 18.38 us | 0.4296 us | 0.0243 us | 7.6294 | 0.8240 |  39.09 KB |


===============================================

// * Detailed results *
TwoBenchmarks.First: Job-ENODZK(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 20.8393 us, StdErr = 0.0487 us (0.23%); N = 3, StdDev = 0.0843 us
Min = 20.7686 us, Q1 = 20.7686 us, Median = 20.8168 us, Q3 = 20.9326 us, Max = 20.9326 us
IQR = 0.1640 us, LowerFence = 20.5225 us, UpperFence = 21.1787 us
ConfidenceInterval = [19.3473 us; 22.3314 us] (CI 99.9%), Margin = 1.4921 us (7.16% of Mean)
Skewness = 0.25, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[20.717 us ; 20.984 us) | @@@
---------------------------------------------------

TwoBenchmarks.Second: Job-ENODZK(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 18.6118 us, StdErr = 0.0544 us (0.29%); N = 3, StdDev = 0.0942 us
Min = 18.5490 us, Q1 = 18.5490 us, Median = 18.5663 us, Q3 = 18.7200 us, Max = 18.7200 us
IQR = 0.1710 us, LowerFence = 18.2925 us, UpperFence = 18.9766 us
ConfidenceInterval = [16.9454 us; 20.2782 us] (CI 99.9%), Margin = 1.6664 us (8.95% of Mean)
Skewness = 0.37, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[18.492 us ; 18.777 us) | @@@
---------------------------------------------------

Total time: 00:00:12 (12.15 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.14393.2214 (1607/AnniversaryUpdate/Redstone1)
Intel Core i7-4820K CPU 3.70GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3613273 Hz, Resolution=276.7574 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |    Error |    StdDev | Scaled |  Gen 0 |  Gen 1 | Allocated |
------- |---------:|---------:|----------:|-------:|-------:|-------:|----------:|
  First | 20.84 us | 1.492 us | 0.0843 us |   1.00 | 7.6294 | 0.8240 |  39.13 KB |
 Second | 18.61 us | 1.666 us | 0.0942 us |   0.89 | 7.6294 | 0.8240 |  39.09 KB |
```

### VM Guest

```
// * Detailed results *
First.Run: Job-NEOEOS(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 18.9294 us, StdErr = 0.1851 us (0.98%); N = 3, StdDev = 0.3206 us
Min = 18.5728 us, Q1 = 18.5728 us, Median = 19.0218 us, Q3 = 19.1937 us, Max = 19.1937 us
IQR = 0.6209 us, LowerFence = 17.6415 us, UpperFence = 20.1250 us
ConfidenceInterval = [13.2557 us; 24.6032 us] (CI 99.9%), Margin = 5.6738 us (29.97% of Mean)
Skewness = -0.26, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[18.378 us ; 18.767 us) | @
[18.767 us ; 19.302 us) | @@
---------------------------------------------------

Total time: 00:00:06 (6.4 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-4820K CPU 3.70GHz (Haswell), 1 CPU, 8 logical and 8 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
------- |---------:|---------:|----------:|-------:|-------:|----------:|
	Run | 18.93 us | 5.674 us | 0.3206 us | 7.6294 | 0.8240 |  39.13 KB |
	
====================================

// * Detailed results *
Second.Run: Job-PYMVHT(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 19.7995 us, StdErr = 0.2065 us (1.04%); N = 3, StdDev = 0.3577 us
Min = 19.4444 us, Q1 = 19.4444 us, Median = 19.7942 us, Q3 = 20.1598 us, Max = 20.1598 us
IQR = 0.7154 us, LowerFence = 18.3713 us, UpperFence = 21.2330 us
ConfidenceInterval = [13.4679 us; 26.1310 us] (CI 99.9%), Margin = 6.3315 us (31.98% of Mean)
Skewness = 0.01, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[19.402 us ; 19.943 us) | @@
[19.943 us ; 20.377 us) | @
---------------------------------------------------

Total time: 00:00:06 (6.53 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-4820K CPU 3.70GHz (Haswell), 1 CPU, 8 logical and 8 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
------- |---------:|---------:|----------:|-------:|-------:|----------:|
	Run | 19.80 us | 6.332 us | 0.3577 us | 7.6294 | 0.8240 |  39.09 KB |
	
=====================================

// * Detailed results *
TwoBenchmarks.First: Job-AMBVZT(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 21.2997 us, StdErr = 0.0759 us (0.36%); N = 3, StdDev = 0.1315 us
Min = 21.1851 us, Q1 = 21.1851 us, Median = 21.2707 us, Q3 = 21.4433 us, Max = 21.4433 us
IQR = 0.2582 us, LowerFence = 20.7979 us, UpperFence = 21.8306 us
ConfidenceInterval = [18.9721 us; 23.6273 us] (CI 99.9%), Margin = 2.3276 us (10.93% of Mean)
Skewness = 0.21, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[21.105 us ; 21.523 us) | @@@
---------------------------------------------------

TwoBenchmarks.Second: Job-AMBVZT(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 21.1438 us, StdErr = 0.0755 us (0.36%); N = 3, StdDev = 0.1308 us
Min = 21.0135 us, Q1 = 21.0135 us, Median = 21.1429 us, Q3 = 21.2751 us, Max = 21.2751 us
IQR = 0.2616 us, LowerFence = 20.6210 us, UpperFence = 21.6676 us
ConfidenceInterval = [18.8285 us; 23.4592 us] (CI 99.9%), Margin = 2.3154 us (10.95% of Mean)
Skewness = 0.01, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[20.934 us ; 21.354 us) | @@@
---------------------------------------------------

Total time: 00:00:13 (13.43 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-4820K CPU 3.70GHz (Haswell), 1 CPU, 8 logical and 8 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |    Error |    StdDev | Scaled |  Gen 0 |  Gen 1 | Allocated |
------- |---------:|---------:|----------:|-------:|-------:|-------:|----------:|
  First | 21.30 us | 2.328 us | 0.1315 us |   1.00 | 7.6294 | 0.8240 |  39.13 KB |
 Second | 21.14 us | 2.315 us | 0.1308 us |   0.99 | 7.6294 | 0.8240 |  39.09 KB |
```

### Surface Pro 3

```
// * Detailed results *
First.Run: Job-RPBIZL(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 21.7219 us, StdErr = 0.0728 us (0.34%); N = 3, StdDev = 0.1261 us
Min = 21.5812 us, Q1 = 21.5812 us, Median = 21.7601 us, Q3 = 21.8244 us, Max = 21.8244 us
IQR = 0.2433 us, LowerFence = 21.2162 us, UpperFence = 22.1894 us
ConfidenceInterval = [19.4908 us; 23.9530 us] (CI 99.9%), Margin = 2.2311 us (10.27% of Mean)
Skewness = -0.28, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[21.505 us ; 21.901 us) | @@@
---------------------------------------------------

Total time: 00:00:07 (7.09 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-4650U CPU 1.70GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
Frequency=2240907 Hz, Resolution=446.2479 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |    Error |    StdDev |   Gen 0 | Allocated |
------- |---------:|---------:|----------:|--------:|----------:|
	Run | 21.72 us | 2.231 us | 0.1261 us | 18.8599 |  39.13 KB |
	
=============================

// * Detailed results *
Second.Run: Job-AFDECD(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 21.7036 us, StdErr = 0.1758 us (0.81%); N = 3, StdDev = 0.3045 us
Min = 21.3944 us, Q1 = 21.3944 us, Median = 21.7131 us, Q3 = 22.0032 us, Max = 22.0032 us
IQR = 0.6087 us, LowerFence = 20.4813 us, UpperFence = 22.9163 us
ConfidenceInterval = [16.3147 us; 27.0925 us] (CI 99.9%), Margin = 5.3889 us (24.83% of Mean)
Skewness = -0.03, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[21.210 us ; 22.077 us) | @@@
---------------------------------------------------

Total time: 00:00:07 (7 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-4650U CPU 1.70GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
Frequency=2240907 Hz, Resolution=446.2479 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |    Error |    StdDev |   Gen 0 | Allocated |
------- |---------:|---------:|----------:|--------:|----------:|
	Run | 21.70 us | 5.389 us | 0.3045 us | 18.8599 |  39.09 KB |
	
===============================


// * Detailed results *
TwoBenchmarks.First: Job-LJOAZK(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 24.5930 us, StdErr = 0.0893 us (0.36%); N = 3, StdDev = 0.1546 us
Min = 24.4708 us, Q1 = 24.4708 us, Median = 24.5412 us, Q3 = 24.7668 us, Max = 24.7668 us
IQR = 0.2960 us, LowerFence = 24.0268 us, UpperFence = 25.2109 us
ConfidenceInterval = [21.8561 us; 27.3299 us] (CI 99.9%), Margin = 2.7369 us (11.13% of Mean)
Skewness = 0.3, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[24.377 us ; 24.861 us) | @@@
---------------------------------------------------

TwoBenchmarks.Second: Job-LJOAZK(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 24.7023 us, StdErr = 0.1738 us (0.70%); N = 3, StdDev = 0.3011 us
Min = 24.4427 us, Q1 = 24.4427 us, Median = 24.6319 us, Q3 = 25.0324 us, Max = 25.0324 us
IQR = 0.5897 us, LowerFence = 23.5582 us, UpperFence = 25.9169 us
ConfidenceInterval = [19.3735 us; 30.0312 us] (CI 99.9%), Margin = 5.3289 us (21.57% of Mean)
Skewness = 0.22, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[24.260 us ; 25.215 us) | @@@
---------------------------------------------------

Total time: 00:00:15 (15.36 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-4650U CPU 1.70GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
Frequency=2240907 Hz, Resolution=446.2479 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |    Error |    StdDev | Scaled |   Gen 0 | Allocated |
------- |---------:|---------:|----------:|-------:|--------:|----------:|
  First | 24.59 us | 2.737 us | 0.1546 us |   1.00 | 18.8599 |  39.13 KB |
 Second | 24.70 us | 5.329 us | 0.3011 us |   1.00 | 18.8599 |  39.09 KB |
```

### Azure VM: Standard D16s v3 (16 vcpus, 64 GB memory)

```
// * Detailed results *
First.Run: Job-XBKCLD(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 28.5615 us, StdErr = 0.3125 us (1.09%); N = 3, StdDev = 0.5414 us
Min = 28.0722 us, Q1 = 28.0722 us, Median = 28.4694 us, Q3 = 29.1431 us, Max = 29.1431 us
IQR = 1.0709 us, LowerFence = 26.4659 us, UpperFence = 30.7494 us
ConfidenceInterval = [18.9804 us; 38.1427 us] (CI 99.9%), Margin = 9.5811 us (33.55% of Mean)
Skewness = 0.17, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[27.942 us ; 28.815 us) | @@
[28.815 us ; 29.471 us) | @
---------------------------------------------------

Total time: 00:00:09 (9.17 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.248 (1709/FallCreatorsUpdate/Redstone3)
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 16 logical and 8 physical cores
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
------- |---------:|---------:|----------:|-------:|-------:|----------:|
	Run | 28.56 us | 9.581 us | 0.5414 us | 6.2561 | 0.6714 |  39.13 KB |


=================

// * Detailed results *
Second.Run: Job-CYIWQV(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 28.5599 us, StdErr = 0.1768 us (0.62%); N = 3, StdDev = 0.3062 us
Min = 28.3721 us, Q1 = 28.3721 us, Median = 28.3943 us, Q3 = 28.9133 us, Max = 28.9133 us
IQR = 0.5412 us, LowerFence = 27.5603 us, UpperFence = 29.7251 us
ConfidenceInterval = [23.1399 us; 33.9799 us] (CI 99.9%), Margin = 5.4200 us (18.98% of Mean)
Skewness = 0.38, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[28.186 us ; 29.099 us) | @@@
---------------------------------------------------

Total time: 00:00:09 (9.22 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.248 (1709/FallCreatorsUpdate/Redstone3)
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 16 logical and 8 physical cores
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
------- |---------:|---------:|----------:|-------:|-------:|----------:|
	Run | 28.56 us | 5.420 us | 0.3062 us | 6.2256 | 0.6714 |  39.09 KB |

======================


// * Detailed results *
TwoBenchmarks.First: Job-OZBAZT(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 33.0181 us, StdErr = 0.2298 us (0.70%); N = 3, StdDev = 0.3981 us
Min = 32.5955 us, Q1 = 32.5955 us, Median = 33.0728 us, Q3 = 33.3859 us, Max = 33.3859 us
IQR = 0.7904 us, LowerFence = 31.4098 us, UpperFence = 34.5716 us
ConfidenceInterval = [25.9730 us; 40.0631 us] (CI 99.9%), Margin = 7.0451 us (21.34% of Mean)
Skewness = -0.13, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[32.354 us ; 33.562 us) | @@@
---------------------------------------------------

TwoBenchmarks.Second: Job-OZBAZT(Toolchain=InProcessToolchain, LaunchCount=1, TargetCount=3, WarmupCount=3)
Runtime = ; GC =
Mean = 33.6534 us, StdErr = 0.5129 us (1.52%); N = 3, StdDev = 0.8884 us
Min = 32.6278 us, Q1 = 32.6278 us, Median = 34.1429 us, Q3 = 34.1893 us, Max = 34.1893 us
IQR = 1.5615 us, LowerFence = 30.2856 us, UpperFence = 36.5316 us
ConfidenceInterval = [17.9291 us; 49.3776 us] (CI 99.9%), Margin = 15.7242 us (46.72% of Mean)
Skewness = -0.38, Kurtosis = 0.67, MValue = 2
-------------------- Histogram --------------------
[32.089 us ; 33.627 us) | @
[33.627 us ; 34.728 us) | @@
---------------------------------------------------

Total time: 00:00:10 (10.78 sec)

// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.248 (1709/FallCreatorsUpdate/Redstone3)
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 16 logical and 8 physical cores
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=3
WarmupCount=3

 Method |     Mean |     Error |    StdDev | Scaled | ScaledSD |  Gen 0 |  Gen 1 | Allocated |
------- |---------:|----------:|----------:|-------:|---------:|-------:|-------:|----------:|
  First | 33.02 us |  7.045 us | 0.3981 us |   1.00 |     0.00 | 6.1646 | 0.6714 |  39.13 KB |
 Second | 33.65 us | 15.724 us | 0.8884 us |   1.02 |     0.02 | 6.1035 | 0.6714 |  39.09 KB |
```