﻿using System;

namespace CCSWE.nanoFramework.Core.Benchmarks
{
    public abstract class BenchmarkBase
    {
        public void RunIterations(int iterations, Action action)
        {
            for (var i = 0; i < iterations; i++)
            {
                action();
            }
        }
    }
}
