using NUnit.Framework;
using System;
using ICT3101_Calculator; // Assuming this is where your calculator class is

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class QualityMetricStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        // Constructor-based dependency injection for the calculator instance
        public QualityMetricStepDefinitions(Calculator calc)
        {
            _calculator = calc;
        }

        // Scenario: Calculate defect density of a system
        [When(@"I enter (.*) defects and (.*) lines of code")]
        public void WhenIEnterDefectsAndLinesOfCode(double defects, double linesOfCode)
        {
            _result = _calculator.CalculateDefectDensity(defects, linesOfCode);
        }

        [Then(@"the defect density should be (.*)")]
        public void ThenTheDefectDensityShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult).Within(0.01),
                $"Expected {expectedResult} but got {_result}");
        }

        // Scenario: Calculate total SSI for multiple releases
        [When(@"I enter (.*) shipped source instructions for the first release and (.*) for the second release")]
        public void WhenIEnterShippedSourceInstructionsForTheFirstReleaseAndForTheSecondRelease(double release1, double release2)
        {
            _result = _calculator.CalculateTotalSSI(release1, release2);
        }

        [Then(@"the total SSI should be (.*)")]
        public void ThenTheTotalSSIShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult),
                $"Expected {expectedResult} but got {_result}");
        }
    }
}
