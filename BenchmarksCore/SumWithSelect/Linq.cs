using BenchmarkDotNet.Attributes;
using System.Linq;

namespace BenchmarksCore.SumWithSelect
{
    [CoreJob, MemoryDiagnoser]
    public partial class SumWithSelect : BenchmarksBase
    {
        [Benchmark(Baseline = true)]
        public int SumWithSelectLinq() => array.Sum(x => x * x);
    }
}
