using ICT3101_Calculator.UnitTests.Context;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    class CalculatorAdditionsSteps
    {
        private readonly CalculatorSharedData calculatorSharedData;
        public CalculatorAdditionsSteps(CalculatorSharedData calculatorSharedData)
        {
            this.calculatorSharedData = calculatorSharedData;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            calculatorSharedData._result = calculatorSharedData._calculator.Add(p0, p1);
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(calculatorSharedData._result, Is.EqualTo(p0));
        }
    }
}
