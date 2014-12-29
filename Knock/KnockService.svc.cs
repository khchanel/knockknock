using System;
using System.Linq;
using knockknock.readify.net;

namespace Knock
{
    public class KnockService : IKnockService
    {
        public Guid WhatIsYourToken()
        {
            //var token = new Guid("8bb8dc4c-065e-4e36-8e0c-208a0465c3f3");
            var token = Guid.Empty;

            return token;
        }


        public long FibonacciNumber(long n)
        {
            const int max = 92;
            if (n > max)
            {
                throw new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");
            }

            long a = 0;
            long b = 1;

            for (long i = 0; i < n; i++)
            {
                var tmp = a;
                a = b;
                b = tmp + b;
            }

            return a;
        }


        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            var values = new[] { a, b, c };

            if (a <= 0 || b <= 0 || c <= 0)
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