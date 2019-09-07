using BenchmarkDotNet.Attributes;
using JM.LinqFaster;

namespace BenchmarksCore.Average
{
    public partial class Average : BenchmarksBase
    {
        [Benchmark]
        public double AverageFast() => array.AverageF();
    }
}
