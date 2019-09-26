using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Min
{
    public partial class Min : BenchmarksBase
    {
        /*
        |      Method | TEST_SIZE |            Mean |          Error |         StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
        |------------ |---------- |----------------:|---------------:|---------------:|------:|-------:|------:|------:|----------:|
        |  MinCistern |       100 |        36.69 ns |      0.5629 ns |      0.5266 ns |  0.07 | 0.0076 |     - |     - |      24 B |
        |     MinFast |       100 |        75.90 ns |      1.1847 ns |      1.1081 ns |  0.14 |      - |     - |     - |         - |
        | MinFastSimd |       100 |        20.26 ns |      0.4240 ns |      0.3310 ns |  0.04 |      - |     - |     - |         - |
        |     MinLinq |       100 |       551.13 ns |      6.7937 ns |      6.0224 ns |  1.00 | 0.0095 |     - |     - |      32 B |
        |             |           |                 |                |                |       |        |       |       |           |
        |  MinCistern |   1000000 |    88,558.60 ns |  1,755.3356 ns |  3,027.8676 ns |  0.02 |      - |     - |     - |      24 B |
        |     MinFast |   1000000 | 1,004,539.55 ns | 10,965.0737 ns |  9,720.2522 ns |  0.19 |      - |     - |     - |         - |
        | MinFastSimd |   1000000 |    94,824.64 ns |  1,869.0675 ns |  1,999.8813 ns |  0.02 |      - |     - |     - |         - |
        |     MinLinq |   1000000 | 5,371,015.16 ns | 62,660.5444 ns | 58,612.7121 ns |  1.00 |      - |     - |     - |      32 B |
        */
        [Benchmark]
        public int MinCistern() => array.Min();
    }
}
