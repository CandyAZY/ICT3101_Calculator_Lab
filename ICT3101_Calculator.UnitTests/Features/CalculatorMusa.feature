Feature: CalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@Musa
Scenario: Calculate current failure intensity
	Given I have a calculator
	When I have entered '10' and '50' and '100' into the calculator and press current failure
	Then the result should be '5'

@Musa
Scenario: Calculate average failure intensity
	Given I have a calculator
	When I have entered '10' and '100' and '100' into the calculator and press average failure
	Then the result should be '100'