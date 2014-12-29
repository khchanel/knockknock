using System;
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
            throw new NotImplementedException();
        }


        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            throw new NotImplementedException();
        }


        public string ReverseWords(string s)
        {
            throw new NotImplementedException();
        }

    }
}