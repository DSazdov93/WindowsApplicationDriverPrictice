using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTesting
{
    [TestFixture]
    public class ScientificCalculatorTest : TestBase
    {
        [SetUp]
        public void SetUp()
        {
            InitializeWinDriver("scientific");
        }

        [TearDown]
        public void TearDown()
        {
            CleanUpWinDriver();
        }

        [Test]
        [TestCase(123, '+', 467, "123 + 467 = 590")]
        public void VerifyHistoryData(double numberOne, char symbol, double numberTwo, string expectedResult)
        {
            scientificCalculator.MathOperationWithNumber(numberOne, symbol, numberTwo);
            scientificCalculator.AssertHistoryItem(expectedResult);
        }

        [Test]
        [TestCase(479, '/', 123, "There’s no history yet")]
        public void VerifyHistoryAfterClickClearButton(double numberOne, char symbol, double numberTwo, string expectedResult)
        {
            scientificCalculator.MathOperationWithNumber(numberOne, symbol, numberTwo);
            scientificCalculator.ClearHistoryResult();
            scientificCalculator.AssertHistoryAfterClickClearButton(expectedResult);
        }

        [Test]
        [TestCase(25, "5")]
        [TestCase(1, "1")]
        [TestCase(0, "0")]
        public void VerifySquareRootResult(double number, string expectedResult)
        {
            scientificCalculator.SquareRootFromNumber(number);
            scientificCalculator.AssertSquareRootResult(expectedResult);
        }

        [Test]
        [TestCase(25, "0.42261826174069943618697848964773")]
        [TestCase(90, "1")]
        [TestCase(0, "0")]
        public void VerifySinResult(double number, string expectedResult)
        {
            scientificCalculator.ClickNumberAndDecimalSeparator(number);
            scientificCalculator.SinButton.Click();
            scientificCalculator.AssertCalculateResult(expectedResult);
        }

        [Test]
        [TestCase(10, "0.98480775301220805936674302458952")]
        [TestCase(0, "1")]
        public void VerifyCosResult(double number, string expectedResult)
        {
            scientificCalculator.ClickNumberAndDecimalSeparator(number);
            scientificCalculator.CosButton.Click();
            scientificCalculator.AssertCalculateResult(expectedResult);
        }

        [Test]
        [TestCase("3.1415926535897932384626433832795")]
        public void VerifyPiButton(string expectedResult)
        {
            scientificCalculator.PiButton.Click();
            scientificCalculator.AssertCalculateResult(expectedResult);
        }
    }
}
