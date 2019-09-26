using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Average
{
    public partial class Average : BenchmarksBase
    {
        /*
        |          Method | TEST_SIZE |            Mean |          Error |         StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
        |---------------- |---------- |----------------:|---------------:|---------------:|------:|-------:|------:|------:|----------:|
        |  AverageCistern |       100 |        96.69 ns |      0.8040 ns |      0.7520 ns |  0.20 | 0.0126 |     - |     - |      40 B |
        |     AverageFast |       100 |        72.57 ns |      0.8737 ns |      0.8173 ns |  0.15 |      - |     - |     - |         - |
        | AverageFastSimd |       100 |        16.13 ns |      0.2034 ns |      0.1902 ns |  0.03 |      - |     - |     - |         - |
        |     AverageLinq |       100 |       481.85 ns |      8.0411 ns |      7.5217 ns |  1.00 | 0.0095 |     - |     - |      32 B |
        |                 |           |                 |                |                |       |        |       |       |           |
        |  AverageCistern |   1000000 |   617,475.53 ns |  9,271.0607 ns |  8,218.5538 ns |  0.13 |      - |     - |     - |      40 B |
        |     AverageFast |   1000000 |   716,200.26 ns | 14,059.3450 ns | 19,244.5902 ns |  0.16 |      - |     - |     - |         - |
        | AverageFastSimd |   1000000 |    97,553.20 ns |  1,910.2606 ns |  2,043.9575 ns |  0.02 |      - |     - |     - |         - |
        |     AverageLinq |   1000000 | 4,586,585.13 ns | 69,942.3169 ns | 65,424.0866 ns |  1.00 |      - |     - |     - |      32 B |
        */
        [Benchmark]
        public double AverageCistern() => array.Average();
    }
}
