using OpenQA.Selenium.Appium.Windows;

namespace CalculatorTesting
{
    public partial class StandartCalculator : BasePage
    {
        public StandartCalculator(WindowsDriver<WindowsElement> driver) : base(driver)
        { }

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
        public WindowsElement ReciprocalButton => Driver.FindElementByName("Reciprocal");
        public WindowsElement SquareButton => Driver.FindElementByName("Square");
        public WindowsElement SquareRootButton => Driver.FindElementByName("Square root");
        public WindowsElement Percentbutton => Driver.FindElementByName("Percent");
        public WindowsElement CalculatorResultDisplay => Driver.FindElementByAccessibilityId("CalculatorResults");
        public WindowsElement NavigationButton => Driver.FindElementByName("Open Navigation");
        public WindowsElement StandartCalculatorMode => Driver.FindElementByName("Standard Calculator");
        public WindowsElement MemoryAddButton => Driver.FindElementByName("Memory add");
        public WindowsElement MemorySubstractButton => Driver.FindElementByName("Memory substract");
        public WindowsElement MemoryStoreButton => Driver.FindElementByName("Memory store");
    }
}
