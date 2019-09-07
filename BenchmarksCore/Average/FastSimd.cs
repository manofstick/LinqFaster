using BenchmarkDotNet.Attributes;
using JM.LinqFaster.SIMD;

namespace BenchmarksCore.Average
{
    public partial class Average : BenchmarksBase
    {
        [Benchmark]
        public double AverageFastSimd() => array.AverageS();
    }
}
