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

        [When(@"I click upload a profile photo")]
        public void WhenIClickUploadAProfilePhoto()
        {
            startPage.MyProfile.ClickUploadProfilePhotoLink();
        }

        [When(@"I upload a new photo")]
        public void WhenIUploadNewPhoto()
        {
            startPage.MyProfile.UploadFile("test.jpg");
        }

        [Then(@"I verify that owner photo is display")]
        public void ThenIVerifyOwnerPhotoIsDisplay()
        {
            startPage.MyProfile.VerifyOwnerPhotoIsDisplay();
        }

        [When(@"I click Save and continue button")]
        public void ThenIClickSaveAndContinueButton()
        {
            startPage.MyProfile.ClickSaveAndContinueButton();
        }

        [When(@"I click Save button")]
        public void ThenIClickSaveButton()
        {
            startPage.MyProfile.ClickSaveButton();
        }

        [Then(@"I verify that avatar is display")]
        public void ThenIverifyThatAvatarIsDisplay()
        {
            startPage.MyProfile.VerifyUploadedAvatarIsDisplay();
        }

        [Then(@"I delete avatar")]
        public void ThenIDeleteAvatar()
        {
            startPage.MyProfile.DeleteAvatar();
        }
    }
}
