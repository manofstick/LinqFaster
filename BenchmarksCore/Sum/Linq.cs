using BenchmarkDotNet.Attributes;
using System.Linq;

namespace BenchmarksCore.Sum
{
    [CoreJob, MemoryDiagnoser]
    public partial class Sum : BenchmarksBase
    {
        [Benchmark(Baseline = true)]
        public int SumLinq() => array.Sum();
    }
}
