using OpenQA.Selenium.Appium.Windows;
using System.Collections.Generic;

namespace CalculatorTesting
{
    public partial class ScientificCalculator : BasePage
    {
        public ScientificCalculator(WindowsDriver<WindowsElement> driver) : base(driver)
        { }
        
        public WindowsElement PiButton => Driver.FindElementByName("Pi");
        public WindowsElement SinButton => Driver.FindElementByName("Sine");
        public WindowsElement CosButton => Driver.FindElementByName("Cosine");
        public WindowsElement TangButton => Driver.FindElementByName("Tangent");
        
    }
}
