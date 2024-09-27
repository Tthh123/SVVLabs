using Lab1;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class DivisionStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        // Constructor-based context injection
        public DivisionStepDefinitions(Calculator calc)
        {
            _calculator = calc;
        }


        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndPressDivide(double p0, double p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBeOnTheScreen(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult));
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
