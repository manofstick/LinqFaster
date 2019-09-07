using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Min
{
    public partial class Min : BenchmarksBase
    {
        [Benchmark]
        public int MinCistern() => array.Min();
    }
}
