using ICT3101_Calculator;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Context
{
    class CalculatorSharedData
    {
        public double _result;
        public Calculator _calculator;
    }

    [Binding]
    class CalculatorContext
    {
        private readonly CalculatorSharedData calculatorSharedData;

        public CalculatorContext(CalculatorSharedData calculatorSharedData)
        {
            this.calculatorSharedData = calculatorSharedData;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            calculatorSharedData._calculator = new Calculator();
        }
    }
}
