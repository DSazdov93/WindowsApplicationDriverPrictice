using OpenQA.Selenium.Appium.Windows;

namespace CalculatorTesting
{
    public partial class StandartCalculator : BasePage
    {
        public StandartCalculator(WindowsDriver<WindowsElement> driver) : base(driver)
        { }
        
        public WindowsElement ReciprocalButton => Driver.FindElementByName("Reciprocal");
        public WindowsElement Percentbutton => Driver.FindElementByName("Percent");

    }
}
