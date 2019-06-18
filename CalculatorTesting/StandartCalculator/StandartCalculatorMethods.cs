
namespace CalculatorTesting
{
    public partial class StandartCalculator
    {
        public void FindPercentOfNumberWithPercentButton(double numberOne, char symbol, double numberTwo)
        {
            ClickNumberAndDecimalSeparator(numberOne);
            ClickMathSymbol(symbol);
            ClickNumberAndDecimalSeparator(numberTwo);
            Percentbutton.Click();
            EqualButton.Click();
        }
    }
}
