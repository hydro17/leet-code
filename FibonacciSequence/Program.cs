using System;
using System.Numerics;

namespace FibonacciSequence
{
    class Program
    {
        private static int sum = 0; 
        private static BigInteger?[] memo;

        static void Main(string[] args)
        {
            //for(int i = 0; i <=7; i++)
            //{
            //    Console.WriteLine($"fibRec({i}) = {FibRecursive(i)}");
            //}

            //for (int i = 0; i <= 7; i++)
            //{
            //    Console.WriteLine($"fibImp({i}) = {FibImperative(i)}");
            //}

            BigInteger n = 40;

            sum = 0;
            memo = new BigInteger?[(long)n+1];
            memo[0] = BigInteger.Zero;
            memo[1] = BigInteger.One;

            Console.WriteLine("long MaxValue = ");
            Console.WriteLine("{0:n0}", long.MaxValue);
            Console.WriteLine("sum = " + sum);
            Console.WriteLine(n);
            Console.WriteLine("{0:n}", FibRecursive(n));
            Console.WriteLine("sum = {0:n0}", sum);
        }

        private static BigInteger FibRecursive(BigInteger n)
        {
            sum += 1;
            if (n == BigInteger.Zero) return BigInteger.Zero;
            if (n == BigInteger.One) return BigInteger.One;
            if (memo[(long)n] != null) return (BigInteger)memo[(long)n];

            memo[(long)n] = FibRecursive(n - 1) + FibRecursive(n - 2);

            //return FibRecursive(n - 1) + FibRecursive(n - 2);

            return (BigInteger)memo[(long)n];
        }

        //private static long FibImperative(long n)
        //{
        //    if (n == 0) return 0;
        //    if (n == 1) return 1;

        //    int x = 0, y = 1, z = 0;

        //    for (int i = 2; i <= n; i++)
        //    {
        //        z = x + y;
        //        x = y;
        //        y = z;
        //    }

        //    return z;
        //}

        //private static long FibMemoization(long n)
        //{
        //    if (n == 0) return 0;
        //    if (n == 1) return 1;

        //    return FibRecursive(n - 1) + FibRecursive(n - 2);
        //}
    }
}
