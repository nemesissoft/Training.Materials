using NUnit.Framework;
using System;

namespace Prosiak.Logic.Tests
{
    [TestFixture]
    internal class PigTests
    {
        [Test]
        public void Test1()
        {
            var sut = new Pig("pig1", DateTime.Today.AddDays(-5));
            var result = sut.Age.Days;
            Assert.AreEqual(5, result);
        }
    }

    internal class PiggyTests
    {
        private Piggy sut;

        [OneTimeSetUp]
        public void SetUp()
        {
            sut = new Piggy("pig2", DateTime.Today.AddDays(-5));
        }


        [Test]
        public void AgeInDaysReturnsExpectedValue()
        {
            var result = sut.Age().Days;
            Assert.AreEqual(5, result);
        }

        [Test]
        public void NameReturnsNiceIntroduction()
        {
            var result = sut.Name;
            Assert.AreEqual("My name is: PIG2", result);
        }
    }
}
