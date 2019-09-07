using BenchmarkDotNet.Attributes;
using JM.LinqFaster.SIMD;

namespace BenchmarksCore.Sum
{
    public partial class Sum : BenchmarksBase
    {
        [Benchmark]
        public int SumFastSimd() => array.SumS();
    }
}
