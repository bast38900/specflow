using specflowlib;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace specflowtest.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
       private readonly Calculator _calculator = new Calculator();

        private int _result;


       [Given("the first number is (.*)")]
       public void GivenTheFirstNumberIs(int number)
       {
           _calculator.FirstNumber = number;
       }

       [Given("the second number is (.*)")]
       public void GivenTheSecondNumberIs(int number)
       {
          _calculator.SecondNumber = number;
        }
        
       [When("the two numbers are added")]
       public void WhenTheTwoNumbersAreAdded()
       {
            _result = _calculator.Add();
       }

       [Then("the result should be (.*)")]
       public void ThenTheResultShouldBe(int result)
       {
            _result.Should().Be(result);
       }
    }
}
