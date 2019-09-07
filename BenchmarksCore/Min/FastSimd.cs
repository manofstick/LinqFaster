using BenchmarkDotNet.Attributes;
using JM.LinqFaster.SIMD;

namespace BenchmarksCore.Min
{
    public partial class Min : BenchmarksBase
    {
        [Benchmark]
        public int MinFastSimd() => array.MinS();
    }
}
