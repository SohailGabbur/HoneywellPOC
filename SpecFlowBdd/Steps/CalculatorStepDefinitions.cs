﻿using System.Runtime.InteropServices;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowBdd.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private int num1;
        private int num2;
        private int _result;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            num1 = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            num2 = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            _result = num1 + num2;
            
        }

        //[When(@"the two numbers are substracted")]
        //public void WhenTheTwoNumbersAreSubstracted()
        //{
        //    _result = num1 - num2;
        //}

        //[When(@"the two numbers are multiplies")]
        //public void WhenTheTwoNumbersAreMultiplies()
        //{
        //    _result = num1 * num2;
        //}

        //[When(@"the two numbers are divided")]
        //public void WhenTheTwoNumbersAreDivided()
        //{
        //    _result = num1 / num2;
        //}


        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            Assert.Equal(result, _result);
        }
    }
}
