using BenchmarkDotNet.Attributes;
using JM.LinqFaster.SIMD;

namespace BenchmarksCore.SumWithSelect
{
    public partial class SumWithSelect : BenchmarksBase
    {
        [Benchmark]
        public int SumWithSelectFastSimd() => array.SumS(x => x * x, x => x * x);
    }
}
