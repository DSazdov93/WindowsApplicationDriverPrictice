using NUnit.Framework;

namespace CalculatorTesting
{
    public partial class ScientificCalculator
    {
        public void AssertCalculateResult(string expectedResult)
        {
            string actualResult = GetCalculatorResult().Trim();
            Assert.AreEqual(expectedResult.Trim(), actualResult);
        }

        public void AssertHistoryItem(string expectedResult)
        {
            string actualResult = GetHistoryItemResult().Trim();
            Assert.AreEqual(expectedResult.Trim(), actualResult);
        }

        public void AssertHistoryAfterClickClearButton(string expectedResult)
        {
            string actualResult = GetHistoryResultWhenShouldBeEmpty();
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void AssertSquareRootResult(string expectedResult)
        {
            string actualResult = GetCalculatorResult().Trim();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
