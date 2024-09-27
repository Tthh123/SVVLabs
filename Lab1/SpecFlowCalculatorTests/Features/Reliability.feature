Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@Reliability
Scenario: Calculating current failure intensity
Given I have a calculator
When I have entered 5 as the initial failure intensity λ₀, 3 as the expected failures μ, and 10 as the total failures v₀
Then the current failure intensity result should be 3.5

@Reliability
Scenario: Calculating average number of expected failures
Given I have a calculator
When I have entered 10 as the total number of failures v₀, 5 as the initial failure intensity λ₀, and 4 as the time τ
Then the expected number of failures result should be 8.65


@Reliability
Scenario: Calculating current failure intensity with larger values
Given I have a calculator
When I have entered 10 as the initial failure intensity λ₀, 6 as the expected failures μ, and 15 as the total failures v₀
Then the current failure intensity result should be 6

@Reliability
Scenario: Calculating current failure intensity with small values
Given I have a calculator
When I have entered 1 as the initial failure intensity λ₀, 0.5 as the expected failures μ, and 2 as the total failures v₀
Then the current failure intensity result should be 0.75

@Reliability
Scenario: Calculating current failure intensity with zero expected failures
Given I have a calculator
When I have entered 5 as the initial failure intensity λ₀, 0 as the expected failures μ, and 10 as the total failures v₀
Then the current failure intensity result should be 5

@Reliability
Scenario: Calculating average number of expected failures with large values for τ
Given I have a calculator
When I have entered 20 as the total number of failures v₀, 8 as the initial failure intensity λ₀, and 10 as the time τ
Then the expected number of failures result should be 19.63

@Reliability
Scenario: Calculating average number of expected failures with small values for τ
Given I have a calculator
When I have entered 10 as the total number of failures v₀, 4 as the initial failure intensity λ₀, and 2 as the time τ
Then the expected number of failures result should be 5.51

@Reliability
Scenario: Calculating average number of expected failures with very small values for λ₀
Given I have a calculator
When I have entered 15 as the total number of failures v₀, 1 as the initial failure intensity λ₀, and 5 as the time τ
Then the expected number of failures result should be 4.25

