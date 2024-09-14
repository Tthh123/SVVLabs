using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    public class CalculatorContext
    {
        // Property to store the calculator instance
        public Calculator Calculator { get; set; }

        // Property to store the result of operations
        public double Result { get; set; }
    }
}