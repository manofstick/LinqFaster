using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Repeat
{
    /*
    |         Method | TEST_SIZE |            Mean |           Error |          StdDev |          Median | Ratio | RatioSD |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
    |--------------- |---------- |----------------:|----------------:|----------------:|----------------:|------:|--------:|--------:|--------:|--------:|----------:|
    |  RepeatCistern |       100 |       185.57 ns |       1.8689 ns |       1.7482 ns |       184.97 ns |  1.80 |    0.02 |  0.1554 |       - |       - |     488 B |
    |     RepeatFast |       100 |        85.77 ns |       1.1497 ns |       1.0754 ns |        85.90 ns |  0.83 |    0.01 |  0.1351 |       - |       - |     424 B |
    | RepeatFastSimd |       100 |        42.87 ns |       0.1812 ns |       0.1513 ns |        42.85 ns |  0.42 |    0.01 |  0.1351 |       - |       - |     424 B |
    |     RepeatLinq |       100 |       103.15 ns |       1.2578 ns |       1.1765 ns |       103.26 ns |  1.00 |    0.00 |  0.1453 |       - |       - |     456 B |
    |                |           |                 |                 |                 |                 |       |         |         |         |         |           |
    |  RepeatCistern |   1000000 | 1,785,113.38 ns |  56,137.4520 ns | 162,864.9274 ns | 1,834,129.30 ns |  1.02 |    0.21 | 50.7813 | 50.7813 | 50.7813 |     438 B |
    |     RepeatFast |   1000000 | 1,754,402.80 ns |  93,813.1720 ns | 276,610.2544 ns | 1,831,192.87 ns |  1.00 |    0.24 | 27.3438 | 27.3438 | 27.3438 |         - |
    | RepeatFastSimd |   1000000 | 1,682,680.21 ns |  48,205.8223 ns | 141,379.3321 ns | 1,717,683.79 ns |  0.96 |    0.18 | 19.5313 | 19.5313 | 19.5313 |         - |
    |     RepeatLinq |   1000000 | 1,814,435.28 ns | 108,206.9514 ns | 319,050.6377 ns | 1,633,454.98 ns |  1.00 |    0.00 | 41.0156 | 41.0156 | 41.0156 |     345 B |
    */
    public partial class Repeat : BenchmarksBase
    {
        [Benchmark]
        public int[] RepeatCistern() => Enumerable.Repeat(5, TEST_SIZE).ToArray();
    }
}
