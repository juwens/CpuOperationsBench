using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CpuOperationsBench
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<OperationsBench>();
        }
    }

    public class OperationsBench
    {
        private readonly double _doubleA;
        private readonly double _doubleB;
        public OperationsBench()
        {
            _doubleA = 1.23456789;
            _doubleB = 98765.4321;
        }

        [Benchmark]
        public double DoubleAdd()
        {
            return _doubleA + _doubleB;
        }

        [Benchmark]
        public double DoubleMul()
        {
            return _doubleA * _doubleB;
        }

        [Benchmark]
        public double DoubleDiv()
        {
            return _doubleA / _doubleB;
        }

        [Benchmark]
        public double DoublePow()
        {
            return Math.Pow(_doubleA, _doubleB);
        }

        [Benchmark]
        public double DoubleSqrt()
        {
            return Math.Sqrt(_doubleA);
        }

        [Benchmark]
        public double DoubleSin()
        {
            return Math.Sin(Math.E);
        }

        [Benchmark]
        public double DoubleCos()
        {
            return Math.Cos(Math.E);
        }

        [Benchmark]
        public double DoubleAsin()
        {
            return Math.Asin(Math.E);
        }

        [Benchmark]
        public double DoubleAcos()
        {
            return Math.Acos(Math.E);
        }

        [Benchmark]
        public int IntAdd()
        {
            return 13 + 42;
        }

        [Benchmark]
        public int IntMul()
        {
            return 13 * 42;
        }

        [Benchmark]
        public int IntDiv()
        {
            return 13 / 42;
        }

        [Benchmark]
        public int IntPow()
        {
            var (quotient, remainder) = Math.DivRem(13, 42);
            return quotient;
        }
    }
}