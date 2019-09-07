using BenchmarkDotNet.Attributes;
using System.Linq;

namespace BenchmarksCore.WhereAggregate
{
    [CoreJob, MemoryDiagnoser]
    public partial class WhereAggregate : BenchmarksBase
    {
        [Benchmark(Baseline = true)]
        public double WhereAggregateLinq() => array.Where(x => x % 2 == 0).Aggregate(0.0, (acc, x) => acc += x * x, acc => acc / array.Length);
    }
}
