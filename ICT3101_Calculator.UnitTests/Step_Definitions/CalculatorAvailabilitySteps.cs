using ICT3101_Calculator.UnitTests.Context;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace _ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    class CalculatorAvailabilitySteps
    {
        private readonly CalculatorSharedData calculatorSharedData;

        public CalculatorAvailabilitySteps(CalculatorSharedData calculatorSharedData)
        {
            this.calculatorSharedData = calculatorSharedData;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            calculatorSharedData._result = calculatorSharedData._calculator.MTBF(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            calculatorSharedData._result = calculatorSharedData._calculator.Availability(p0, p1);
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(Decimal p0)
        {
            Assert.That(calculatorSharedData._result, Is.EqualTo(p0));
        }
    }
}
