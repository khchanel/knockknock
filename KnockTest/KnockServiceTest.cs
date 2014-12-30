using System;
using System.ServiceModel;
using Knock;
using knockknock.readify.net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockTest
{
    [TestClass]
    public class KnockServiceTest
    {
        private IKnockService _service;

        [TestInitialize]
        public void Init()
        {
            _service = new KnockService();
        }

        [TestMethod]
        public void Token()
        {
            var actual = _service.WhatIsYourToken();

            Assert.IsInstanceOfType(actual, typeof (Guid));
            Assert.IsNotNull(actual);
            //Assert.AreNotEqual(Guid.Empty, actual);
        }

        [TestMethod]
        public void FibonacciNumberPositive()
        {
            var fibs = new long[] {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765};

            for (int i = 0; i < fibs.Length; i++)
            {
                Assert.AreEqual(fibs[i], _service.FibonacciNumber(i));
            }
        }

        [TestMethod]
        public void FibonacciNumberNegative()
        {
            var fibs = new long[] {0, 1, -1, 2, -3, 5, -8, 13, -21};

            for (int i = 0; i < fibs.Length; i++)
            {
                Assert.AreEqual(fibs[i], _service.FibonacciNumber(-i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<ArgumentOutOfRangeException>))]
        public void FibonacciNumberOutOfRange()
        {
            _service.FibonacciNumber(93);
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<ArgumentOutOfRangeException>))]
        public void FibonacciNumberOutOfRangeNegative()
        {
            _service.FibonacciNumber(-93);
        }

        [TestMethod]
        public void ReverseWordsWithOneWord()
        {
            const string word = "Apple";
            const string expected = "elppA";

            var actual = _service.ReverseWords(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseWordsWithTwoWords()
        {
            const string word = "Apple Orange";
            const string expected = "elppA egnarO";

            var actual = _service.ReverseWords(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseWordsWithTwoWordsWithSymbols()
        {
            const string word = "Apple Orange123Tree .-#Banana";
            const string expected = "elppA eerT321egnarO ananaB#-.";

            var actual = _service.ReverseWords(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof (FaultException<ArgumentNullException>))]
        public void ReverseWordsNull()
        {
            _service.ReverseWords(null);
        }

        [TestMethod]
        public void WhatShapeIsThisWithEquilateral()
        {
            const int a = 3;
            const int b = 3;
            const int c = 3;
            const TriangleType expected = TriangleType.Equilateral;

            var actual = _service.WhatShapeIsThis(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhatShapeIsThisWithIsosceles()
        {
            const int a = 1;
            const int b = 3;
            const int c = 3;
            const TriangleType expected = TriangleType.Isosceles;

            var actual = _service.WhatShapeIsThis(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhatShapeIsThisWithScalene()
        {
            const int a = 12;
            const int b = 6;
            const int c = 14;
            const TriangleType expected = TriangleType.Scalene;

            var actual = _service.WhatShapeIsThis(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhatShapeIsThisWithZero()
        {
            const int a = 1;
            const int b = 0;
            const int c = 4;
            const TriangleType expected = TriangleType.Error;

            var actual = _service.WhatShapeIsThis(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
