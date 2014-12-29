using System;
using System.Threading.Tasks;
using knockknock.readify.net;

namespace Knock
{
    public class KnockService : IKnockService
    {
        public Guid WhatIsYourToken()
        {
            throw new NotImplementedException();
        }

        public Task<Guid> WhatIsYourTokenAsync()
        {
            throw new NotImplementedException();
        }

        public long FibonacciNumber(long n)
        {
            throw new NotImplementedException();
        }

        public Task<long> FibonacciNumberAsync(long n)
        {
            throw new NotImplementedException();
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public Task<TriangleType> WhatShapeIsThisAsync(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public string ReverseWords(string s)
        {
            throw new NotImplementedException();
        }

        public Task<string> ReverseWordsAsync(string s)
        {
            throw new NotImplementedException();
        }
    }
}