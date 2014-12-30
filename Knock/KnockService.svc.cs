using System;
using System.Linq;
using System.ServiceModel;
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
            long absN = Math.Abs(n);
            
            if (absN > max)
            {
                var ex = new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");
                throw new FaultException<ArgumentOutOfRangeException>(ex, ex.Message);
            }

            long a = 0;
            long b = 1;

            for (long i = 0; i < absN; i++)
            {
                var tmp = a;
                a = b;
                b = tmp + b;
            }

            if (n < 0 && absN%2 == 0)
            {
                return -a;
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
            if (s == null)
            {
                var ex = new ArgumentNullException("s");
                throw new FaultException<ArgumentNullException>(ex, ex.Message);
            }

            var words = s.Split(' ');

            for (var i=0; i<words.Length; i++)
            {
                words[i] = words[i].Inverse();
            }

            return String.Join(" ", words);
        }

    }

    static class StringExtensions
    {
        public static string Inverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }

}
