using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Average
{
    public partial class Average : BenchmarksBase
    {
        [Benchmark]
        public double AverageCistern() => array.Average();
    }
}
