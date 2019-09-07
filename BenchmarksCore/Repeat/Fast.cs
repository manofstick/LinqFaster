using BenchmarkDotNet.Attributes;
using JM.LinqFaster;

namespace BenchmarksCore.Repeat
{
    public partial class Repeat : BenchmarksBase
    {
        [Benchmark]
        public int[] RepeatFast() => LinqFaster.RepeatArrayF(5, TEST_SIZE);
    }
}
