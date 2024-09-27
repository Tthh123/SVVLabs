Feature: Factorial
	In order to conquer divisions
	As a division enthusiast
	I want to understand a variety of division operations

A short summary of the feature

@Factorial
Scenario: Calculate the factorial of a positive number
  Given I have a calculator
  When I have entered the number 5 into the calculator and press factorial
  Then the factorial result should be 120

@Factorial
Scenario: Calculate the factorial of zero
  Given I have a calculator
  When I have entered the number 0 into the calculator and press factorial
  Then the factorial result should be 1
