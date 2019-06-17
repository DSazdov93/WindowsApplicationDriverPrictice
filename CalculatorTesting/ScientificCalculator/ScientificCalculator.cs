using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTesting
{
    public partial class ScientificCalculator
    {
        public void ClickNumberAndDecimalSeparator(double number)
        {
            char[] charNumber = number.ToString().ToCharArray();

            for (int i = 0; i < charNumber.Length; i++)
            {
                switch (charNumber[i])
                {
                    case '0':
                        ZeroButton.Click();
                        break;
                    case '1':
                        OneButton.Click();
                        break;
                    case '2':
                        TwoButton.Click();
                        break;
                    case '3':
                        ThreeButton.Click();
                        break;
                    case '4':
                        FourButton.Click();
                        break;
                    case '5':
                        FiveButton.Click();
                        break;
                    case '6':
                        SixButton.Click();
                        break;
                    case '7':
                        SevenButton.Click();
                        break;
                    case '8':
                        EigthButton.Click();
                        break;
                    case '9':
                        NineButton.Click();
                        break;
                    case '.':
                        DecimalSeparator.Click();
                        break;
                }
            }
        }

        public void ClickMathSymbol(char mathSymbol)
        {
            switch (mathSymbol)
            {
                case '+':
                    PlusButton.Click();
                    break;
                case '-':
                    SubtractButton.Click();
                    break;
                case '*':
                    MultiplyButton.Click();
                    break;
                case '/':
                    DivideButton.Click();
                    break;
                case '=':
                    EqualButton.Click();
                    break;
                case '%':
                    Percentbutton.Click();
                    break;
            }
        }

        private string GetCalculatorResult()
        {
            string actualResult = CalculatorResultDisplay.Text.Remove(0, 10);
            return actualResult;
        }

        public void MathOperationWithNumber(double numberOne, char mathSymbol, double numberTwo)
        {
            ClickNumberAndDecimalSeparator(numberOne);
            ClickMathSymbol(mathSymbol);
            ClickNumberAndDecimalSeparator(numberTwo);
            EqualButton.Click();
        }

        public string GetHistoryResultWhenShouldBeEmpty()
        {
            string actualResult = HistoryEmptyDisplay.Text;
            return actualResult;
        }

        public string GetHistoryItemResult()
        {
            string actualResult = HistoryItem.Text;
            return actualResult;
        }

        public void ClearHistoryResult()
        {
            bool isClearButtonIsVisible = ClearHistoryButton.Enabled;
            if (isClearButtonIsVisible)
            {
                ClearHistoryButton.Click();
            }
        }

        public void SquareRootFromNumber(double number)
        {
            ClickNumberAndDecimalSeparator(number);
            SquareRootButton.Click();
            EqualButton.Click();
        }
    }
}
