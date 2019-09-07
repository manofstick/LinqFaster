using BenchmarkDotNet.Attributes;
using JM.LinqFaster;

namespace BenchmarksCore.Max
{
    public partial class Max : BenchmarksBase
    {
        [Benchmark]
        public int MaxFast() => array.MaxF();
    }
}
