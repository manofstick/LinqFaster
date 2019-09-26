using BenchmarkDotNet.Attributes;
using Cistern.Linq;

namespace BenchmarksCore.Select
{
    /*
    |         Method | TEST_SIZE |            Mean |           Error |          StdDev |          Median | Ratio | RatioSD |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
    |--------------- |---------- |----------------:|----------------:|----------------:|----------------:|------:|--------:|---------:|---------:|--------:|----------:|
    |  SelectCistern |       100 |       729.85 ns |       7.8623 ns |       7.3544 ns |       729.81 ns |  2.47 |    0.05 |   0.3891 |        - |       - |    1224 B |
    |     SelectFast |       100 |       284.07 ns |       3.8313 ns |       3.5838 ns |       285.49 ns |  0.96 |    0.01 |   0.1349 |        - |       - |     424 B |
    | SelectFastSimd |       100 |        78.93 ns |       0.6836 ns |       0.6394 ns |        79.06 ns |  0.27 |    0.00 |   0.1351 |        - |       - |     424 B |
    |     SelectLinq |       100 |       296.00 ns |       3.7949 ns |       3.5498 ns |       296.57 ns |  1.00 |    0.00 |   0.1502 |        - |       - |     472 B |
    |                |           |                 |                 |                 |                 |       |         |          |          |         |           |
    |  SelectCistern |   1000000 | 6,078,860.40 ns | 114,384.1754 ns | 112,340.5547 ns | 6,041,754.30 ns |  2.45 |    0.14 | 750.0000 | 421.8750 | 93.7500 | 4022400 B |
    |     SelectFast |   1000000 | 2,543,115.86 ns |  50,305.4436 ns | 139,396.1472 ns | 2,553,165.23 ns |  1.00 |    0.08 |  62.5000 |  62.5000 | 62.5000 |         - |
    | SelectFastSimd |   1000000 | 1,694,879.45 ns | 108,404.8522 ns | 319,634.1524 ns | 1,567,507.81 ns |  0.67 |    0.13 |  46.8750 |  46.8750 | 46.8750 |         - |
    |     SelectLinq |   1000000 | 2,553,196.38 ns |  50,752.9601 ns | 144,801.0510 ns | 2,544,744.92 ns |  1.00 |    0.00 |  54.6875 |  54.6875 | 54.6875 |     439 B |
    */
    public partial class Select : BenchmarksBase
    {
        [Benchmark]
        public int[] SelectCistern() => array.Select(x => x * x).ToArray();
    }
}
