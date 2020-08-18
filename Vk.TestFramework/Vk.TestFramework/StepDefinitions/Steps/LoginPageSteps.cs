using CAD.CD.Search.TestFramework.Config;
using CAD.CD.Search.TestFramework.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Vk.TestFramework.StepDefinitions.Steps
{
    public class LoginPageSteps: BaseStepDefenition
    {
        public LoginPageSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"I have login into application using test credentials")]
        public void GivenIHaveLoginIntoApplicationUsingTestCredentials()
        {
            var testCreds = ConfigLoader.LoadJson("testCreds");
            loginPage.TypeInUsernameInput(Convert.ToString(testCreds.username));
            loginPage.TypeInPasswordInput(Convert.ToString(testCreds.password));
            loginPage.ClickSignInButton();
        }
        [Then(@"I verify that login page is open")]
        public void IVerifyThatLoginPageIsOpen()
        {
            loginPage.VerifyThatSignInButtonDisplayed();
        }
    }
}
