using BenchmarkDotNet.Attributes;
using JM.LinqFaster;

namespace BenchmarksCore.SumWithSelect
{
    public partial class SumWithSelect : BenchmarksBase
    {
        [Benchmark]
        public int SumWithSelectFast() => array.SumF(x => x * x);
    }
}
