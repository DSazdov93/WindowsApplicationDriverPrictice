using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTesting
{
    public partial class ScientificCalculator
    {
        public void FindNumberFromSine(double number)
        {
            ClickNumberAndDecimalSeparator(number);
            SinButton.Click();
        }

        public void FindNumberFromCosine(double number)
        {
            ClickNumberAndDecimalSeparator(number);
            CosButton.Click();
        }
    }
}
