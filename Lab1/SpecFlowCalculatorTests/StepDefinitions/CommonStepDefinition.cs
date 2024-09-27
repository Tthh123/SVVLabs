using Lab1;
using ICT3101_Calculator;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CommonStepDefinitions
    {
        private Calculator _calculator;

        public CommonStepDefinitions(Calculator calc)
        {
            _calculator = calc;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            if (_calculator == null)
            {
                _calculator = new Calculator();
            }
        }
    }
}
