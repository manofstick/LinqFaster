using BenchmarkDotNet.Attributes;
using JM.LinqFaster;

namespace BenchmarksCore.Select
{
    public partial class Select : BenchmarksBase
    {
        [Benchmark]
        public int[] SelectFast() => array.SelectF(x => x * x);
    }
}
