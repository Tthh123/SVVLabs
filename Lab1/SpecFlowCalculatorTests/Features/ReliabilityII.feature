#Epic: To calculate quality metrics(SSI/DD/Musa) via the command line calculator

Feature: Reliability Calculations Using Musa Logarithmic Model

  In order to calculate the Logarithmic Musa model's failures/intensities
  As a Software Quality Metric enthusiast
  I want to use my calculator to do this


#UserStory:
#As a system quality engineer,
#I want to calculate failure intensity using the Musa Logarithmic model,
#so that I can predict the frequency of system failures over time.
 @ReliabilityII
  Scenario: Calculate failure intensity using Musa Logarithmic model
    Given I have a calculator
    When I enter 5 as the initial failure intensity, 0.2 as the failure intensity decay parameter, and 3 as the expected failures
    Then the failure intensity should be 2.74

  @ReliabilityII
  Scenario: Calculate failure intensity with larger decay parameter
    Given I have a calculator
    When I enter 6 as the initial failure intensity, 0.3 as the failure intensity decay parameter, and 4 as the expected failures
    Then the failure intensity should be 1.81

  @ReliabilityII
  Scenario: Calculate failure intensity with smaller decay parameter
    Given I have a calculator
    When I enter 7 as the initial failure intensity, 0.1 as the failure intensity decay parameter, and 3 as the expected failures
    Then the failure intensity should be 5.19

  @ReliabilityII
  Scenario: Calculate failure intensity with very small decay parameter
    Given I have a calculator
    When I enter 8 as the initial failure intensity, 0.05 as the failure intensity decay parameter, and 2 as the expected failures
    Then the failure intensity should be 7.24


#UserStory:
#As a system quality engineer,
#I want to calculate the expected number of failures over time using the Musa Logarithmic model,
#so that I can estimate system reliability and plan for maintenance.
  @ReliabilityII
  Scenario: Calculate expected number of failures using Musa Logarithmic model
    Given I have a calculator
    When I enter 5 as the initial failure intensity, 0.3 as the failure intensity decay parameter, and 4 as time
    Then the expected number of failures should be 6.49

  @ReliabilityII
  Scenario: Calculate expected number of failures with smaller time
    Given I have a calculator
    When I enter 5 as the initial failure intensity, 0.3 as the failure intensity decay parameter, and 2 as time
    Then the expected number of failures should be 4.62

  @ReliabilityII
  Scenario: Calculate expected number of failures with large values of time
    Given I have a calculator
    When I enter 6 as the initial failure intensity, 0.2 as the failure intensity decay parameter, and 10 as time
    Then the expected number of failures should be 12.82

  @ReliabilityII
  Scenario: Calculate expected number of failures with small values for λ₀
    Given I have a calculator
    When I enter 1 as the initial failure intensity, 0.5 as the failure intensity decay parameter, and 3 as time
    Then the expected number of failures should be 1.83

  @ReliabilityII
  Scenario: Calculate failure intensity with zero expected failures
    Given I have a calculator
    When I enter 5 as the initial failure intensity, 0.1 as the failure intensity decay parameter, and 0 as the expected failures
    Then the failure intensity should be 5

  @ReliabilityII
  Scenario: Calculate failure intensity with very small expected failures
    Given I have a calculator
    When I enter 10 as the initial failure intensity, 0.05 as the failure intensity decay parameter, and 0.5 as the expected failures
    Then the failure intensity should be 9.75