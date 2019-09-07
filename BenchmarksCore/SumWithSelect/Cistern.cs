using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.SumWithSelect
{
    public partial class SumWithSelect : BenchmarksBase
    {
        [Benchmark]
        public int SumWithSelectCistern() => array.Sum(x => x * x);
    }
}
