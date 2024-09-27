using Lab1;
using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class AvailabilityStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        // Constructor-based context injection
        public AvailabilityStepDefinitions(Calculator calc)
        {
            _calculator = calc;
        }

        // MTBF Calculation Step Definitions
        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndPressMTBF(double MTTF, double MTTR)
        {
            _result = _calculator.CalculateMTBF(MTTF, MTTR);
        }

        [Then(@"the MTBF result should be (.*)")]
        public void ThenTheMTBFResultShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult));
        }

        // Availability Calculation Step Definitions
        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndPressAvailability(double MTTF, double MTBF)
        {
            _result = _calculator.CalculateAvailability(MTTF, MTBF);
        }
 
        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult).Within(0.01));

        }
    }
}
