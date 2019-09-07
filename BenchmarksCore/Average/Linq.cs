using BenchmarkDotNet.Attributes;
using System.Linq;

namespace BenchmarksCore.Average
{
    [CoreJob, MemoryDiagnoser]
    public partial class Average : BenchmarksBase
    {
        [Benchmark(Baseline = true)]
        public double AverageLinq() => array.Average();
    }
}
