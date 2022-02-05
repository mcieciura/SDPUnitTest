using System;
using AutoFixture;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using CheckPrime;

namespace TestPrime
{
    public class TestPrime
    {
        [Test]
        public void ExceptionNegativeValue()
        {
            Assert.Throws<ArgumentException>(() => CheckPrimes.IsPrime(-5));
        }

        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(7, true)]
        [TestCase(8, false)]
        [TestCase(9, false)]
        public void CheckValue(int value, bool expectedValue)
        {

            var actualValue = CheckPrimes.IsPrime(value);

            actualValue.Should().Be(expectedValue);
        }
    }
}
