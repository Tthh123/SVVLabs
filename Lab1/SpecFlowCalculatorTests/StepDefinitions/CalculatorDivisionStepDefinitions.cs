using Lab1;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class DivisionStepDefinitions
    {
        private readonly CalculatorContext _context;

        // Constructor-based context injection
        public DivisionStepDefinitions(CalculatorContext context)
        {
            _context = context;
        }


        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndPressDivide(double p0, double p1)
        {
            _context.Result = _context.Calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBeOnTheScreen(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.That(_context.Result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
