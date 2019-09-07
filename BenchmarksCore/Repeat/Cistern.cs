using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Repeat
{
    public partial class Repeat : BenchmarksBase
    {
        [Benchmark]
        public int[] RepeatCistern() => Enumerable.Repeat(5, TEST_SIZE).ToArray();
    }
}
