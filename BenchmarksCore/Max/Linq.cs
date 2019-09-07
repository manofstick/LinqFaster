using BenchmarkDotNet.Attributes;
using System.Linq;

namespace BenchmarksCore.Max
{
    [CoreJob, MemoryDiagnoser]
    public partial class Max : BenchmarksBase
    {
        [Benchmark(Baseline = true)]
        public int MaxLinq() => array.Max();
    }
}
