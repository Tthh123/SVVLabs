Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this

@Availability
Scenario: Calculating MTBF
Given I have a calculator
When I have entered 200 and 10 into the calculator and press MTBF
Then the MTBF result should be 210

@Availability
Scenario: Calculating Availability
Given I have a calculator
When I have entered 200 and 210 into the calculator and press Availability
Then the availability result should be 95.23

@Availability
Scenario: Calculating MTBF with zero MTTR
Given I have a calculator
When I have entered 200 and 0 into the calculator and press MTBF
Then the MTBF result should be 200

@Availability
Scenario: Calculating Availability when MTBF equals MTTF
Given I have a calculator
When I have entered 200 and 200 into the calculator and press Availability
Then the availability result should be 100

@Availability
Scenario: Calculating MTBF with large MTTR values
Given I have a calculator
When I have entered 50 and 1000 into the calculator and press MTBF
Then the MTBF result should be 1050

@Availability
Scenario: Calculating Availability with large MTTR values
Given I have a calculator
When I have entered 50 and 1050 into the calculator and press Availability
Then the availability result should be 4.76

@Availability
Scenario: Calculating Availability when MTTF is zero
Given I have a calculator
When I have entered 0 and 100 into the calculator and press Availability
Then the availability result should be 0
