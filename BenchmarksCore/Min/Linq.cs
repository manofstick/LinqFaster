using BenchmarkDotNet.Attributes;
using System.Linq;

namespace BenchmarksCore.Min
{
    [CoreJob, MemoryDiagnoser]
    public partial class Min : BenchmarksBase
    {
        [Benchmark(Baseline = true)]
        public int MinLinq() => array.Min();
    }
}
