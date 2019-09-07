using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Select
{
    public partial class Select : BenchmarksBase
    {
        [Benchmark]
        public int[] SelectCistern() => array.Select(x => x * x).ToArray();
    }
}
