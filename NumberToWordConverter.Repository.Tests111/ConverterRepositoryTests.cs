using NumberToWordConverter.Repository.Contracts;
using NUnit.Framework;

namespace NumberToWordConverter.Repository.Tests
{
    [TestFixture]
    public class ConverterRepositoryTests
    {
        #region Test Cases For Only Integer
        [Test]
        public void ConvertSingleDigitNumber()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("");
            Assert.That(expectedResult.Trim().ToUpper().Equals("SEVEN"));

        }
        [Test]
        public void ConvertSingleDigitCurrency()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("7");
            Assert.That(expectedResult.Trim().ToUpper().Equals("SEVEN DOLLARS"));
        }

        [Test]
        public void ConvertDoubleDigitNumber()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("52");
            Assert.That(expectedResult.Trim().ToUpper().Equals("FIFTY TWO"));
        }

        [Test]
        public void ConvertDoubleDigitCurrency()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("52");
            Assert.That(expectedResult.Trim().ToUpper().Equals("FIFTY TWO DOLLARS"));
        }

        [Test]
        public void ConvertTripleDigitNumber()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("152");
            Assert.That(expectedResult.Trim().ToUpper().Equals("ONE HUNDRED FIFTY TWO"));
        }

        [Test]
        public void ConvertTripleDigitCurrency()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("152");
            Assert.That(expectedResult.Trim().ToUpper().Equals("ONE HUNDRED FIFTY TWO DOLLARS"));
        }


        [Test]
        public void ConvertFiveDigitCurrency()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("15211");
            Assert.That(expectedResult.Trim().ToUpper().Equals("FIFTEEN THOUSAND TWO HUNDRED ELEVEN DOLLARS"));
        }

        [Test]
        public void ConvertSixDigitNumber()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("152111");
            Assert.That(expectedResult.Trim().ToUpper().Equals("ONE HUNDRED FIFTY TWO THOUSAND ONE HUNDRED ELEVEN"));
        }

        [Test]
        public void ConvertSixDigitCurrency()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("152111");
            Assert.That(expectedResult.Trim().ToUpper().Equals("ONE HUNDRED FIFTY TWO THOUSAND ONE HUNDRED ELEVEN DOLLARS"));
        }

        [Test]
        public void ConvertSevenDigitNumber()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("1521112");
            Assert.That(expectedResult.Trim().ToUpper().Equals("ONE MILLION FIVE HUNDRED TWENTY ONE THOUSAND ONE HUNDRED TWELVE"));
        }

        [Test]
        public void ConvertEightDigitNumber()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("15211125");
            Assert.That(expectedResult.Trim().ToUpper().Equals("FIFTEEN MILLION TWO HUNDRED ELEVEN THOUSAND ONE HUNDRED TWENTY FIVE"));
        }

        [Test]
        public void ConvertEightDigitCurrency()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("15211125");
            Assert.That(expectedResult.Trim().ToUpper().Equals("FIFTEEN MILLION TWO HUNDRED ELEVEN THOUSAND ONE HUNDRED TWENTY FIVE DOLLARS"));
        }
#endregion

        #region Test Cases For Only Decimal

        [Test]
        public void ConvertDecimalDigitNumber()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord(".76");
            Assert.That(expectedResult.Trim().ToUpper().Equals("POINT SEVEN SIX"));

        }

        [Test]
        public void ConvertDecimalDigitCurrency()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord(".76");
            Assert.That(expectedResult.Trim().ToUpper().Equals("SEVEN SIX CENT"));
        }

        #endregion

        #region Test Cases For Both Integer and Decimal

        [Test]
        public void ConvertBothDigitNumber()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("17.76");
            Assert.That(expectedResult.Trim().ToUpper().Equals("SEVENTEEN  POINT SEVEN SIX"));

        }

        [Test]
        public void ConvertBothDigitCurrency()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("17.76");
            Assert.That(expectedResult.Trim().ToUpper().Equals("SEVENTEEN DOLLARS  AND SEVEN SIX CENT"));
        }

        #endregion

        #region Test Case For Minus Number

        [Test]
        public void ConvertNegativeDigitNumber()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("-9");
            Assert.That(expectedResult.Trim().ToUpper().Equals("MINUS NINE"));

        }

        [Test]
        public void ConvertNegativeDigitCurrency()
        {
            IConverterRepository sut = new ConverterRepository();
            string expectedResult = sut.ConvertNumberToWord("-9");
            Assert.That(expectedResult.Trim().ToUpper().Equals("MINUS NINE DOLLARS"));
        }

        #endregion
    }
}
