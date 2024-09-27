using Lab1;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class BasicReliabilityStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        // Constructor-based context injection
        public BasicReliabilityStepDefinitions(Calculator calc)
        {
            _calculator = calc;
        }

        // Step definition for current failure intensity (cfi)
        [When(@"I have entered (.*) as the initial failure intensity λ₀, (.*) as the expected failures μ, and (.*) as the total failures v₀")]
        public void WhenIHaveEnteredInitialFailureIntensityAndExpectedFailuresAndTotalFailures(double lambda0, double mu, double v0)
        {
            _result = _calculator.DoOperation(lambda0, mu, v0, "cfi");
        }

        [Then(@"the current failure intensity result should be (.*)")]
        public void ThenTheCurrentFailureIntensityResultShouldBe(double expectedResult)
        {
            // Allowing a tolerance of 0.01 to account for floating-point precision errors
            Assert.That(_result, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Step definition for average number of expected failures (aef)
        [When(@"I have entered (.*) as the total number of failures v₀, (.*) as the initial failure intensity λ₀, and (.*) as the time τ")]
        public void WhenIHaveEnteredTotalNumberOfFailuresAndInitialFailureIntensityAndTime(double v0, double lambda0, double tau)
        {
            _result = _calculator.DoOperation(v0, lambda0, tau, "aef");
        }

        [Then(@"the expected number of failures result should be (.*)")]
        public void ThenTheExpectedNumberOfFailuresResultShouldBe(double expectedResult)
        {
            // Allowing a tolerance of 0.01 to account for floating-point precision errors
            Assert.That(_result, Is.EqualTo(expectedResult).Within(0.01));
        }

    }
}
