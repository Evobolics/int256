﻿using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Evo.Primitives;
using Evo.Constants;

namespace Evo.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class SubtractSigned : SignedTwoParamBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public BigInteger Subtract_BigInteger()
        {
            return (A.Item1 - B.Item1) % Numbers.TwoTo256;
        }

        [Benchmark]
        public Int256 Subtract_Int256()
        {
            Int256.Subtract(A.Item2, B.Item2, out Int256 res);
            return res;
        }
    }
}
