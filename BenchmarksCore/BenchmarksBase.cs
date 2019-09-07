using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace BenchmarksCore
{
    [MemoryDiagnoser]
    public class BenchmarksBase
    {
        const int LARGE_TEST_SIZE = 1000000;
        const int SMALL_TEST_SIZE = 100;

        public List<int> list;
        public int[] array;
        public int[] array2;
        public float[] floatArray;
        public string[] strarray;

        [Params(SMALL_TEST_SIZE, LARGE_TEST_SIZE)]
        public int TEST_SIZE { get; set; }

        public BenchmarksBase() {}

        [GlobalSetup]
        public void Setup()
        {
            Random r = new Random();
            array = new int[TEST_SIZE];
            array2 = new int[TEST_SIZE];
            floatArray = new float[TEST_SIZE];
            list = new List<int>(TEST_SIZE);
            strarray = new string[TEST_SIZE];

            for (int i = 0; i < TEST_SIZE; i++)
            {
                array[i] = r.Next(-100,100);
                array2[i] = r.Next(-100,100);                
                list.Add(array[i]);
                strarray[i] = array[i].ToString();
                floatArray[i] = array[i];
            }
            array2[TEST_SIZE / 2] = 0;
        }
    }
}
