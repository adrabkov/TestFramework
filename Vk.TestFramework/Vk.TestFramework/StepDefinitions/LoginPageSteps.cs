using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Vk.TestFramework.StepDefinitions
{
    [Binding]
    public class LoginPageSteps:BaseStepDefenition
    {
        public LoginPageSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"I have login into application using test credentials")]
        public void GivenIHaveLoginIntoApplicationUsingTestCredentials()
        {
            //var testCreds = ConfigLoader.LoadJson("testCreds");
            loginPage.LogIn("test");
            //loginPage.TypeInPasswordInput(Convert.ToString(testCreds.password));
            //loginPage.ClickSignInButton();
        }
    }
}
