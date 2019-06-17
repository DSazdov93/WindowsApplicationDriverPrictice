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
        protected StandartCalculator standartCalculator;
        protected ScientificCalculator scientificCalculator;

        
        public void InitializeWinDriver(string calculatorView)
        {
            if (_driver == null)
            {
                DesiredCapabilities appCapability = new DesiredCapabilities();
                appCapability.SetCapability("app", calculatorApplicationId);
                appCapability.SetCapability("deviceName", "WindowsPC");
                _driver = new WindowsDriver<WindowsElement>(new Uri(windowsApplicationDriverUri), appCapability);
                _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3.0));

                switch (calculatorView.ToLower())
                {
                    case "standart":
                        standartCalculator = new StandartCalculator(_driver);
                        standartCalculator.NavigationButton.Click();
                        standartCalculator.StandartCalculatorMode.Click();
                        break;
                    case "scientific":
                        scientificCalculator = new ScientificCalculator(_driver);
                        scientificCalculator.NavigationButton.Click();
                        scientificCalculator.ScientificCalculatorMode.Click();
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
