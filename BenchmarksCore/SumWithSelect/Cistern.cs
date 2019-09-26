using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.SumWithSelect
{
    /*
    |                Method | TEST_SIZE |          Mean |         Error |        StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    |---------------------- |---------- |--------------:|--------------:|--------------:|------:|--------:|-------:|------:|------:|----------:|
    |  SumWithSelectCistern |       100 |     307.53 ns |     2.2006 ns |     2.0584 ns |  0.48 |    0.00 | 0.0229 |     - |     - |      72 B |
    |     SumWithSelectFast |       100 |     194.24 ns |     2.2831 ns |     2.1356 ns |  0.30 |    0.00 |      - |     - |     - |         - |
    | SumWithSelectFastSimd |       100 |      48.49 ns |     0.6179 ns |     0.5780 ns |  0.08 |    0.00 |      - |     - |     - |         - |
    |     SumWithSelectLinq |       100 |     645.54 ns |     6.3141 ns |     5.9062 ns |  1.00 |    0.00 | 0.0095 |     - |     - |      32 B |
    |                       |           |               |               |               |       |         |        |       |       |           |
    |  SumWithSelectCistern |   1000000 |            NA |            NA |            NA |     ? |       ? |      - |     - |     - |         - |
    |     SumWithSelectFast |   1000000 |            NA |            NA |            NA |     ? |       ? |      - |     - |     - |         - |
    | SumWithSelectFastSimd |   1000000 | 358,065.96 ns | 4,406.7488 ns | 4,122.0756 ns |     ? |       ? |      - |     - |     - |         - |
    |     SumWithSelectLinq |   1000000 |            NA |            NA |            NA |     ? |       ? |      - |     - |     - |         - |
    */
    public partial class SumWithSelect : BenchmarksBase
    {
        [Benchmark]
        public int SumWithSelectCistern() => array.Sum(x => x * x);
    }
}
