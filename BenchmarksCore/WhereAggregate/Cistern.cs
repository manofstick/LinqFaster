using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.WhereAggregate
{
    public partial class WhereAggregate : BenchmarksBase
    {
        [Benchmark]
        public double WhereAggregateCistern() => array.Where(x => x % 2 == 0).Aggregate(0.0, (acc, x) => acc += x * x, acc => acc / array.Length);
    }
}
