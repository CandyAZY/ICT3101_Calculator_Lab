using ICT3101_Calculator.UnitTests.Context;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace _ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    class CalculatorBasicReliabilitySteps
    {
        private readonly CalculatorSharedData calculatorSharedData;

        public CalculatorBasicReliabilitySteps(CalculatorSharedData calculatorSharedData)
        {
            this.calculatorSharedData = calculatorSharedData;
        }

        [When(@"I have entered '(.*)' and '(.*)' and '(.*)' into the calculator and press current failure")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressCurrentFailure(int p0, int p1, int p2)
        {
            calculatorSharedData._result = this.calculatorSharedData._calculator.CurrentFailure(p0, p1, p2);
        }

        [When(@"I have entered '(.*)' and '(.*)' and '(.*)' into the calculator and press average failure")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressAverageFailure(int p0, int p1, int p2)
        {
            calculatorSharedData._result = this.calculatorSharedData._calculator.AverageFailure(p0, p1, p2);
        }

        [Then(@"the result should be '(.*)'")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(calculatorSharedData._result, Is.EqualTo(p0));
        }
    }
}
