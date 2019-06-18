using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;

namespace CalculatorTesting
{
    public abstract class TestBase
    {
        private const string windowsApplicationDriverUri = "http://127.0.0.1:4723";
        private const string calculatorApplicationId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
        protected WindowsDriver<WindowsElement> _driver;
        protected StandartCalculator standardCalculator;
        protected ScientificCalculator scientificCalculator;
        


        public void InitializeWinDriver(string calculatorView)
        {
            if (_driver == null)
            {
                DesiredCapabilities appCapability = new DesiredCapabilities();
                appCapability.SetCapability("app", calculatorApplicationId);
                appCapability.SetCapability("deviceName", "WindowsPC");
                _driver = new WindowsDriver<WindowsElement>(new Uri(windowsApplicationDriverUri), appCapability);
                _driver.Manage().Window.Maximize();
                _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3.0));
                 WindowsElement header = _driver.FindElementByAccessibilityId("Header");
                string headerName = header.Text;

                switch (calculatorView.ToLower())
                {
                    case "standard":
                        standardCalculator = new StandartCalculator(_driver);
                        if (headerName.ToLower() != "standard")
                        {
                            standardCalculator.NavigationButton.Click();
                            standardCalculator.StandartCalculatorMode.Click();
                        }
                        break;

                    case "scientific":
                        scientificCalculator = new ScientificCalculator(_driver);
                        if (headerName.ToLower() != "scientific")
                        {
                            scientificCalculator.NavigationButton.Click();
                            scientificCalculator.ScientificCalculatorMode.Click();
                        }
                        break;
                }
            }
        }

        public void CleanUpWinDriver()
        {
            if (_driver != null)
            {
                _driver.CloseApp();
                _driver = null;
            }
        }
    }
}
