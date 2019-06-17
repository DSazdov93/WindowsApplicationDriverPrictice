using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTesting
{
    [TestFixture]
    public class StandartCalculatorTest : TestBase
    {
        [SetUp]
        public void SetUp()
        {
            InitializeWinDriver("standart");
        }

        [TearDown]
        public void TearDown()
        {
            CleanUpWinDriver();
        }

        [Test]
        [TestCase(14.5, '+', 25, "39.5")]
        [TestCase(0, '+', 10.0, "10")]
        [TestCase(10, '+', 0, "10")]
        [TestCase(0, '+', 0, "0")]
        public void VerifyAddNumber(double numberOne, char symbol, double numberTwo, string expectedResult)
        {
            standartCalculator.MathOperation(numberOne, symbol, numberTwo);
            standartCalculator.AssertResult(expectedResult);
        }

        [Test]
        [TestCase(1, '-', 1, "0")]
        [TestCase(0, '-', 10, "-10")]
        [TestCase(10.99, '-', 0, "10.99")]
        [TestCase(0, '-', 0, "0")]
        public void VerifySubtractNumber(double numberOne, char symbol, double numberTwo, string expectedResult)
        {
            standartCalculator.MathOperation(numberOne, symbol, numberTwo);
            standartCalculator.AssertResult(expectedResult);
        }

        [Test]
        [TestCase(1.10, '*', 1, "1.1")]
        [TestCase(0, '*', 10, "0")]
        [TestCase(10, '*', 0, "0")]
        [TestCase(0, '*', 0, "0")]
        public void VerifyMultiplyNumber(double numberOne, char symbol, double numberTwo, string expectedResult)
        {
            standartCalculator.MathOperation(numberOne, symbol, numberTwo);
            standartCalculator.AssertResult(expectedResult);
        }

        [Test]
        [TestCase(1, '/', 1, "1")]
        [TestCase(0, '/', 10, "0")]
        [TestCase(10, '/', 0, "Cannot divide by zero")]
        [TestCase(0, '/', 0, "Result is undefined")]
        [TestCase(5.5, '/', 10, "0.55")]
        public void VerifyDivideNumber(double numberOne, char symbol, double numberTwo, string expectedResult)
        {
            standartCalculator.MathOperation(numberOne, symbol, numberTwo);
            standartCalculator.AssertResult(expectedResult);
        }

        [Test]
        [TestCase(5,'*', 20, "10")]
        public void VerifyResultAfterClickBackspaceButton(double number, char symbol, double numberTwo, string expectedResult)
        {
            standartCalculator.ClickNumberAndDecimalSeparator(number);
            standartCalculator.ClickMathSymbol(symbol);
            standartCalculator.ClickNumberAndDecimalSeparator(numberTwo);
            standartCalculator.BackspaceButton.Click();
            standartCalculator.EqualButton.Click();
            standartCalculator.AssertResult(expectedResult);
        }
    }
}

