using NUnit.Framework;

namespace Prosiak.Logic.Tests
{
    [TestFixture]
    internal class CurrencyConverterTests
    {
        [Test]
        public void ConvertFromUsdToPln_ReturnsExpectedValue()
        {
            var sut = new CurrencyConverter();
            var result = sut.ConvertFromUsdToPln(1);
            Assert.That(result, Is.EqualTo(3.8));
        }
    }
}   
