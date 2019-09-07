using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Sum
{
    public partial class Sum : BenchmarksBase
    {
        [Benchmark]
        public int SumCistern() => array.Sum();
    }
}
