using BenchmarkDotNet.Attributes;
using JM.LinqFaster.SIMD;

namespace BenchmarksCore.Select
{
    public partial class Select : BenchmarksBase
    {
        [Benchmark]
        public int[] SelectFastSimd() => array.SelectS(x => x * x, x => x * x);
    }
}
