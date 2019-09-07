using BenchmarkDotNet.Attributes;
using JM.LinqFaster;

namespace BenchmarksCore.WhereAggregate
{
    public partial class WhereAggregate : BenchmarksBase
    {
        [Benchmark]
        public double WhereAggregateFast() => array.WhereAggregateF(x => x % 2 == 0, 0.0, (acc, x) => acc += x * x, acc => acc / array.Length);
    }
}
