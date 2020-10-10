using ICT3101_Calculator.UnitTests.Context;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    class CalculatorFactorialSteps
    {
        private readonly CalculatorSharedData calculatorSharedData;

        public CalculatorFactorialSteps(CalculatorSharedData calculatorSharedData)
        {
            this.calculatorSharedData = calculatorSharedData;
        }

        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            calculatorSharedData._result = calculatorSharedData._calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(int p0)
        {
            Assert.That(calculatorSharedData._result, Is.EqualTo(p0));
        }
    }
}
