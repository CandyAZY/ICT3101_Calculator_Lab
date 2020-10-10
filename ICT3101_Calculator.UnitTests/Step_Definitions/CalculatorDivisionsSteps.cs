using ICT3101_Calculator.UnitTests.Context;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    class CalculatorDivisionsSteps
    {
        private readonly CalculatorSharedData calculatorSharedData;
        public CalculatorDivisionsSteps(CalculatorSharedData calculatorSharedData)
        {
            this.calculatorSharedData = calculatorSharedData;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            calculatorSharedData._result = calculatorSharedData._calculator.Divide(p0, p1);
        }
        
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(decimal p0)
        {
            Assert.That(calculatorSharedData._result, Is.EqualTo(p0));
        }
        
        
        [Then(@"the division result should be positive infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.IsTrue(double.IsPositiveInfinity(calculatorSharedData._result));
        }
    }
}
