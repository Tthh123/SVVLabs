using NUnit.Framework;
using System;
using ICT3101_Calculator; // Assuming this is where your calculator class is

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class ReliabilityStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        // Constructor-based dependency injection for the calculator instance
        public ReliabilityStepDefinitions(Calculator calc)
        {
            _calculator = calc;
        }

        // Scenario: Calculate failure intensity using Logarithmic model
        [When(@"I enter (.*) as the initial failure intensity, (.*) as the failure intensity decay parameter, and (.*) as the expected failures")]
        public void WhenIEnterAsTheInitialFailureIntensityAsTheFailureIntensityDecayParameterAndAsTheExpectedFailures(double lambda0, double theta, double mu)
        {
            _result = _calculator.CalculateLogModelFailureIntensity(lambda0, theta, mu);
        }

        [Then(@"the failure intensity should be (.*)")]
        public void ThenTheFailureIntensityShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult).Within(0.01),
                $"Expected {expectedResult} but got {_result}");
        }

        // Scenario: Calculate expected number of failures using Logarithmic model
        [When(@"I enter (.*) as the initial failure intensity, (.*) as the failure intensity decay parameter, and (.*) as time")]
        public void WhenIEnterAsTheInitialFailureIntensityAsTheFailureIntensityDecayParameterAndAsTime(double lambda0, double theta, double tau)
        {
            _result = _calculator.CalculateLogModelExpectedFailures(lambda0, theta, tau);
        }

        [Then(@"the expected number of failures should be (.*)")]
        public void ThenTheExpectedNumberOfFailuresShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult).Within(0.01),
                $"Expected {expectedResult} but got {_result}");
        }
    }
}
