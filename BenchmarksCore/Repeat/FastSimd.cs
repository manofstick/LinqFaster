using BenchmarkDotNet.Attributes;
using JM.LinqFaster.SIMD;

namespace BenchmarksCore.Repeat
{
    public partial class Repeat : BenchmarksBase
    {
        [Benchmark]
        public int[] RepeatFastSimd() => LinqFasterSIMD.RepeatS(5, TEST_SIZE);
    }
}
