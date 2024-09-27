#Epic: To calculate quality metrics(SSI/DD/Musa) via the command line calculator

Feature: Quality Metric Calculations

  In order to evaluate the quality and size of the system,
  As a system quality engineer,
  I want to calculate defect density and shipped source instructions (SSI) across releases.


#UserStory:
#As a system quality engineer,
#I want to be able to calculate the defect density of a system,
#so that I can measure the quality and stability of the software.
  @DefectDensity
  Scenario: Calculate defect density of a system
    Given I have a calculator
    When I enter 100 defects and 5000 lines of code
    Then the defect density should be 0.02

  @DefectDensity
  Scenario: Calculate defect density with a different size of code
    Given I have a calculator
    When I enter 50 defects and 2500 lines of code
    Then the defect density should be 0.02


#UserStory:
#As a system quality engineer,
#I want to calculate the total number of Shipped Source Instructions (SSI) across successive releases,
#so that I can track the changes in code size and complexity over time.
  @SSI
  Scenario: Calculate total SSI for multiple releases
    Given I have a calculator
    When I enter 2000 shipped source instructions for the first release and 3000 for the second release
    Then the total SSI should be 5000