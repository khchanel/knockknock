using System;
using System.Linq;
using knockknock.readify.net;

namespace Knock
{
    public class KnockService : IKnockService
    {
        public Guid WhatIsYourToken()
        {
            var token = new Guid("8bb8dc4c-065e-4e36-8e0c-208a0465c3f3");

            return token;
        }


        public long FibonacciNumber(long n)
        {
            const int max = 92;
            if (n > max)
            {
                throw new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");
            }

            var sqrt5 = Math.Sqrt(5);
            var p1 = (1 + sqrt5) / 2;
            var p2 = -1 * (p1 - 1);
            var n1 = Math.Pow(p1, n + 1);
            var n2 = Math.Pow(p2, n + 1);
            var f = (long) ((n1 - n2)/sqrt5);

            return f;
        }


        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            var values = new[] { a, b, c };

            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }

            if (a + b <= c || b + c <= a || a + c <= b)
            {
                return TriangleType.Error;
            }

            switch (values.Distinct().Count())
            {
                case 1:
                    return TriangleType.Equilateral;
                case 2:
                    return TriangleType.Isosceles;
                case 3:
                    return TriangleType.Scalene;
                default:
                    return TriangleType.Error;
            }
        }


        public string ReverseWords(string s)
        {
            return new string(s.ToCharArray().Reverse().ToArray());
        }

    }
}