using BenchmarkDotNet.Attributes;
using System.Linq;

namespace BenchmarksCore.Repeat
{
    [CoreJob, MemoryDiagnoser]
    public partial class Repeat : BenchmarksBase
    {
        [Benchmark(Baseline = true)]
        public int[] RepeatLinq() => Enumerable.Repeat(5, TEST_SIZE).ToArray();
    }
}
