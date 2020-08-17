using CAD.CD.Search.TestFramework.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Vk.TestFramework.StepDefinitions.Steps
{
    public class MyProfileStep : BaseStepDefenition
    {
        public MyProfileStep(ScenarioContext scenarioContext) : base(scenarioContext) { }
        
        [Then(@"I verify that the user has successfully log in to the app")]
        public void IVerifyThatUserSuccessfullyLigIn()
        {
            startPage.MyProfile.VerifythatUserSuccessfullyLogIn();
        }

        [When(@"I click top profile menu")]
        public void IClickTopProfileMenu()
        {
            startPage.MyProfile.ClickTopProfileLink();
        }

        [When(@"I click log out button")]
        public void IClickLogOutButton()
        {
            startPage.MyProfile.ClickLogOutLink();
        }
    }
}
