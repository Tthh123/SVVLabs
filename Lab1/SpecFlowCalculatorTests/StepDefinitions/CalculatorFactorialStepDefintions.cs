using Lab1;
using ICT3101_Calculator;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    internal class CalculatorFactorialStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        // Using the shared instance of Calculator from the common step definitions
        public CalculatorFactorialStepDefinitions(Calculator calc)
        {
            _calculator = calc;
        }
        

        [When(@"I have entered the number (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredTheNumberIntoTheCalculatorAndPressFactorial(int number)
        {
            _result = _calculator.Factorial(number);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult));
        }
    }
}
