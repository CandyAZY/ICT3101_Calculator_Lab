Feature: CalculatorFactorial
	In order to conquer factorial
	As a factorial enthusiast
	I want to understand a variety of factorial operations

@Factorial
Scenario: Factorial normal numbers
	Given I have a calculator
	When I have entered "3" into the calculator and press factorial
	Then the factorial result should be "6"

@Factorial
Scenario: Factorial zero numbers
	Given I have a calculator
	When I have entered "0" into the calculator and press factorial
	Then the factorial result should be "1"
