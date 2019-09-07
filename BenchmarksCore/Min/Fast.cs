using BenchmarkDotNet.Attributes;
using JM.LinqFaster;

namespace BenchmarksCore.Min
{
    public partial class Min : BenchmarksBase
    {
        [Benchmark]
        public int MinFast() => array.MinF();
    }
}
