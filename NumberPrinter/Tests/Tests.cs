using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NumberTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void NegativeTest()
        {
            bool processed = NumberService.Service.NumberReturn(-1, null, Console.WriteLine);
            Assert.AreEqual(false, processed);
        }

        [Test]
        public void ZeroTest()
        {
            bool processed = NumberService.Service.NumberReturn(0, null, Console.WriteLine);
            Assert.AreEqual(false, processed);
        }

        [Test]
        public void FifteenTest()
        {
            List<Tuple<int, string>> pairs = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz")
            };

            bool processed = NumberService.Service.NumberReturn(15, pairs, Console.WriteLine);
            Assert.AreEqual(true, processed);
        }

        [Test]
        public void FiftyTest()
        {
            List<Tuple<int, string>> pairs = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz"),
                new Tuple<int, string>(7, "Bang")
            };

            bool processed = NumberService.Service.NumberReturn(50, pairs, Console.WriteLine);
            Assert.AreEqual(true, processed);
        }

        [Test]
        public void FiveHundredTest()
        {
            List<Tuple<int, string>> pairs = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz"),
                new Tuple<int, string>(7, "Bang"),
                new Tuple<int, string>(13, "Pop")
            };

            bool processed = NumberService.Service.NumberReturn(500, pairs, Console.WriteLine);
            Assert.AreEqual(true, processed);
        }
    }
}