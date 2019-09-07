using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Max
{
    public partial class Max : BenchmarksBase
    {
        [Benchmark]
        public int MaxCistern() => array.Max();
    }
}
