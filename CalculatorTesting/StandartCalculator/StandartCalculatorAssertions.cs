using NUnit.Framework;

namespace CalculatorTesting
{
    public partial class StandartCalculator
    {
        public void AssertResult(string expectedResult)
        {
            string actualResult = GetCalculatorResult().Trim();
            string expectedResultStr = expectedResult.Trim();
            Assert.AreEqual(expectedResultStr, actualResult);
        }
    }
}
