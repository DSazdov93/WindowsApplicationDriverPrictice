using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;

namespace CalculatorTesting
{
    public abstract class BasePage
    {
        private WindowsDriver<WindowsElement> _driver;

        public BasePage(WindowsDriver<WindowsElement> driver)
        {
            this._driver = driver;
        }

        public WindowsDriver<WindowsElement> Driver => this._driver;

        public WindowsElement ZeroButton => Driver.FindElementByName("Zero");
        public WindowsElement OneButton => Driver.FindElementByName("One");
        public WindowsElement TwoButton => Driver.FindElementByName("Two");
        public WindowsElement ThreeButton => Driver.FindElementByName("Three");
        public WindowsElement FourButton => Driver.FindElementByName("Four");
        public WindowsElement FiveButton => Driver.FindElementByName("Five");
        public WindowsElement SixButton => Driver.FindElementByName("Six");
        public WindowsElement SevenButton => Driver.FindElementByName("Seven");
        public WindowsElement EigthButton => Driver.FindElementByName("Eight");
        public WindowsElement NineButton => Driver.FindElementByName("Nine");
        public WindowsElement PositivNegativeButton => Driver.FindElementByName("Positive Negativ");
        public WindowsElement DecimalSeparator => Driver.FindElementByName("Decimal Separator");
        public WindowsElement EqualButton => Driver.FindElementByName("Equals");
        public WindowsElement PlusButton => Driver.FindElementByName("Plus");
        public WindowsElement SubtractButton => Driver.FindElementByName("Minus");
        public WindowsElement MultiplyButton => Driver.FindElementByName("Multiply by");
        public WindowsElement DivideButton => Driver.FindElementByName("Divide by");
        public WindowsElement BackspaceButton => Driver.FindElementByName("Backspace");
        public WindowsElement ClearButton => Driver.FindElementByName("Clear");
        public WindowsElement ClearEntryButton => Driver.FindElementByName("Clear entry");
        public WindowsElement SquareButton => Driver.FindElementByName("Square");
        public WindowsElement SquareRootButton => Driver.FindElementByName("Square root");
        public WindowsElement CalculatorResultDisplay => Driver.FindElementByAccessibilityId("CalculatorResults");
        public WindowsElement NavigationButton => Driver.FindElementByName("Open Navigation");
        public WindowsElement ScientificCalculatorMode => Driver.FindElementByName("Scientific Calculator");
        public WindowsElement HistoryItem => Driver.FindElementByClassName("ListViewItem");
        public WindowsElement HistoryEmptyDisplay => Driver.FindElementByAccessibilityId("HistoryEmpty");
        public WindowsElement ClearHistoryButton => Driver.FindElementByAccessibilityId("ClearHistory");
        public WindowsElement StandartCalculatorMode => Driver.FindElementByName("Standard Calculator");
        public WindowsElement MemoryAddButton => Driver.FindElementByName("Memory add");
        public WindowsElement MemorySubstractButton => Driver.FindElementByName("Memory substract");
        public WindowsElement MemoryStoreButton => Driver.FindElementByName("Memory store");

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
                
            }
        }

        public void SquareRootFromNumber(double number)
        {
            ClickNumberAndDecimalSeparator(number);
            SquareRootButton.Click();
            EqualButton.Click();
        }

        public void ClearHistoryResult()
        {
            bool isClearButtonIsVisible = ClearHistoryButton.Enabled;
            if (isClearButtonIsVisible)
            {
                ClearHistoryButton.Click();
            }
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

        protected string GetCalculatorResult()
        {
            string actualResult = CalculatorResultDisplay.Text.Remove(0, 10);
            return actualResult;
        }
        
        public void MathOperation(double numberOne, char mathSymbol, double numberTwo)
        {
            ClickNumberAndDecimalSeparator(numberOne);
            ClickMathSymbol(mathSymbol);
            ClickNumberAndDecimalSeparator(numberTwo);
            EqualButton.Click();
        }
    }
}
