using Lab1;
using ICT3101_Calculator;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CommonStepDefinitions
    {
        private readonly CalculatorContext _context;

        public CommonStepDefinitions(CalculatorContext context)
        {
            _context = context;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            if (_context.Calculator == null)
            {
                _context.Calculator = new Calculator();
            }
        }
    }
}
