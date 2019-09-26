using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Max
{
    public partial class Max : BenchmarksBase
    {
        /*
        |      Method | TEST_SIZE |            Mean |          Error |         StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
        |------------ |---------- |----------------:|---------------:|---------------:|------:|-------:|------:|------:|----------:|
        |  MaxCistern |       100 |        38.93 ns |      0.3983 ns |      0.3726 ns |  0.07 | 0.0076 |     - |     - |      24 B |
        |     MaxFast |       100 |        78.98 ns |      1.2757 ns |      1.1933 ns |  0.14 |      - |     - |     - |         - |
        | MaxFastSimd |       100 |        20.08 ns |      0.2153 ns |      0.2013 ns |  0.04 |      - |     - |     - |         - |
        |     MaxLinq |       100 |       561.73 ns |     10.6609 ns |     10.9479 ns |  1.00 | 0.0095 |     - |     - |      32 B |
        |             |           |                 |                |                |       |        |       |       |           |
        |  MaxCistern |   1000000 |    84,595.81 ns |  1,635.0228 ns |  1,679.0480 ns |  0.02 |      - |     - |     - |      24 B |
        |     MaxFast |   1000000 |   624,746.91 ns | 14,130.5381 ns | 16,821.4004 ns |  0.12 |      - |     - |     - |         - |
        | MaxFastSimd |   1000000 |   102,600.48 ns |  1,952.7843 ns |  2,005.3657 ns |  0.02 |      - |     - |     - |         - |
        |     MaxLinq |   1000000 | 5,218,455.52 ns | 27,515.8888 ns | 25,738.3795 ns |  1.00 |      - |     - |     - |      32 B |
         */
        [Benchmark]
        public int MaxCistern() => array.Max();
    }
}
