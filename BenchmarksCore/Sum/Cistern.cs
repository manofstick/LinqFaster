using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Sum
{
    /*
    |      Method | TEST_SIZE |            Mean |          Error |         StdDev |          Median | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    |------------ |---------- |----------------:|---------------:|---------------:|----------------:|------:|-------:|------:|------:|----------:|
    |  SumCistern |       100 |        84.91 ns |      0.5771 ns |      0.5398 ns |        85.08 ns |  0.17 | 0.0076 |     - |     - |      24 B |
    |     SumFast |       100 |        69.35 ns |      0.8559 ns |      0.8006 ns |        69.50 ns |  0.14 |      - |     - |     - |         - |
    | SumFastSimd |       100 |        15.82 ns |      1.4284 ns |      2.2656 ns |        14.65 ns |  0.04 |      - |     - |     - |         - |
    |     SumLinq |       100 |       488.53 ns |      7.2206 ns |      6.7542 ns |       491.44 ns |  1.00 | 0.0095 |     - |     - |      32 B |
    |             |           |                 |                |                |                 |       |        |       |       |           |
    |  SumCistern |   1000000 |   520,587.05 ns |  6,227.1931 ns |  5,824.9202 ns |   520,683.59 ns |  0.11 |      - |     - |     - |      24 B |
    |     SumFast |   1000000 |   618,613.42 ns |  7,582.6850 ns |  7,092.8483 ns |   617,741.70 ns |  0.13 |      - |     - |     - |         - |
    | SumFastSimd |   1000000 |   102,644.72 ns |  1,972.9462 ns |  1,845.4951 ns |   102,319.76 ns |  0.02 |      - |     - |     - |         - |
    |     SumLinq |   1000000 | 4,655,685.49 ns | 49,097.0762 ns | 45,925.4356 ns | 4,671,114.45 ns |  1.00 |      - |     - |     - |      32 B |
    */
    public partial class Sum : BenchmarksBase
    {
        [Benchmark]
        public int SumCistern() => array.Sum();
    }
}
