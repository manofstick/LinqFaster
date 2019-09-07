using BenchmarkDotNet.Attributes;
using JM.LinqFaster;

namespace BenchmarksCore.Sum
{
    public partial class Sum : BenchmarksBase
    {
        [Benchmark]
        public int SumFast() => array.SumF();
    }
}
