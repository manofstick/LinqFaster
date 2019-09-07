using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using JM.LinqFaster;
using JM.LinqFaster.Parallel;
using JM.LinqFaster.SIMD.Parallel;
using JM.LinqFaster.SIMD;

using System.Linq;
using System.Collections.Generic;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace Tests
{
    [MemoryDiagnoser]
    public class Program
    {
        /*
        [Benchmark]
        public int OrderByLinq()
        {
            return array.OrderBy((x => x -1)).Sum();
        }

        [Benchmark]
        public int OrderByFast()
        {
            return array.OrderByF((x => x - 1)).Sum();
        }




        [Benchmark]
        public bool SequenceEqual()
        {
            return array.SequenceEqual(array2);
        }*/

        /*
        [Benchmark]
        public bool SequenceEqualP()
        {
            return array.SequenceEqualP(array2);
        }

        [Benchmark]
        public bool SequenceEqualS()
        {
            return array.SequenceEqualS(array2);
        }

        [Benchmark]
        public bool SequenceEqualSP()
        {
            return array.SequenceEqualSP(array2);
        }

    */




        public static void Main(string[] args)
        {
#if ORIGINAL
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] b = { 1, 0, 4, 4, 6, 7, 2, 10 };
            var r = a.SequenceCompareS(b);
            a.Slice(2, 4).SumF();
            foreach (var i in r)
            {
                Console.Write(i + ",");
            }

            var summary = BenchmarkRunner.Run<Benchmarks>(ManualConfig.Create(DefaultConfig.Instance).With(Job.RyuJitX64));
            Console.ReadLine();
#else
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
#endif
        }

    }
}
