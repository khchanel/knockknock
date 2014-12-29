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
            throw new NotImplementedException();
        }


        public string ReverseWords(string s)
        {
            return new string(s.ToCharArray().Reverse().ToArray());
        }

    }
}