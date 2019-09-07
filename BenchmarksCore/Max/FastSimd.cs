using BenchmarkDotNet.Attributes;
using JM.LinqFaster.SIMD;

namespace BenchmarksCore.Max
{
    public partial class Max : BenchmarksBase
    {
        [Benchmark]
        public int MaxFastSimd() => array.MaxS();
    }
}
