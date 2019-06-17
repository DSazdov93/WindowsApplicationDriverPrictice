using OpenQA.Selenium.Appium.Windows;
using System.Collections.Generic;

namespace CalculatorTesting
{
    public partial class ScientificCalculator : BasePage
    {
        public ScientificCalculator(WindowsDriver<WindowsElement> driver) : base(driver)
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
        public WindowsElement ScientificCalculatorMode => Driver.FindElementByName("Scientific Calculator");
        public WindowsElement PiButton => Driver.FindElementByName("Pi");
        public WindowsElement SinButton => Driver.FindElementByName("Sine");
        public WindowsElement CosButton => Driver.FindElementByName("Cosine");
        public WindowsElement TangButton => Driver.FindElementByName("Tangent");
        public WindowsElement HistoryItem => Driver.FindElementByClassName("ListViewItem");
        public WindowsElement HistoryEmptyDisplay => Driver.FindElementByAccessibilityId("HistoryEmpty");
        public WindowsElement ClearHistoryButton => Driver.FindElementByAccessibilityId("ClearHistory");
    }
}
