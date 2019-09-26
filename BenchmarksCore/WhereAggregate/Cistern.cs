using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.WhereAggregate
{
   /*
   |                Method | TEST_SIZE |            Mean |         Error |        StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
   |---------------------- |---------- |----------------:|--------------:|--------------:|------:|-------:|------:|------:|----------:|
   | WhereAggregateCistern |       100 |        426.5 ns |      6.184 ns |      5.785 ns |  0.52 | 0.0505 |     - |     - |     160 B |
   |    WhereAggregateFast |       100 |        381.6 ns |      2.200 ns |      2.057 ns |  0.47 | 0.0200 |     - |     - |      64 B |
   |    WhereAggregateLinq |       100 |        815.9 ns |     12.684 ns |     11.865 ns |  1.00 | 0.0353 |     - |     - |     112 B |
   |                       |           |                 |               |               |       |        |       |       |           |
   | WhereAggregateCistern |   1000000 |  6,984,851.6 ns | 95,668.125 ns | 89,488.024 ns |  0.69 |      - |     - |     - |     160 B |
   |    WhereAggregateFast |   1000000 |  6,901,033.3 ns | 56,664.955 ns | 53,004.434 ns |  0.69 |      - |     - |     - |      64 B |
   |    WhereAggregateLinq |   1000000 | 10,066,523.3 ns | 93,443.448 ns | 87,407.059 ns |  1.00 |      - |     - |     - |     112 B |
   */
    public partial class WhereAggregate : BenchmarksBase
    {
        [Benchmark]
        public double WhereAggregateCistern() => array.Where(x => x % 2 == 0).Aggregate(0.0, (acc, x) => acc += x * x, acc => acc / array.Length);
    }
}
