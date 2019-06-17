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
    }
}
