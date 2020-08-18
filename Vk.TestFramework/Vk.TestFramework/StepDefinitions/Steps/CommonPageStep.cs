using CAD.CD.Search.TestFramework.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Vk.TestFramework.StepDefinitions.Steps
{
    public class CommonPageStep : BaseStepDefenition
    {
        public CommonPageStep(ScenarioContext scenarioContext) : base(scenarioContext) {}

        [When(@"I click My profile menu")]
        public void WhenIClickMyProfileMenu()
        {
            startPage.CommonPage.ClickMyProfileItem();
        }
    }
}
