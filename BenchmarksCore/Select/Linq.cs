using BenchmarkDotNet.Attributes;
using System.Linq;

namespace BenchmarksCore.Select
{
    [CoreJob, MemoryDiagnoser]
    public partial class Select : BenchmarksBase
    {
        [Benchmark(Baseline = true)]
        public int[] SelectLinq() => array.Select(x => x * x).ToArray();
    }
}
