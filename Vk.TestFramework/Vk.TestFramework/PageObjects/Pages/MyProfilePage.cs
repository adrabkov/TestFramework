using CAD.CD.Search.TestFramework.Driver;
using CAD.CD.Search.TestFramework.PageObjects;
using CAD.CD.Search.TestFramework.PageObjects.PageElements;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Vk.TestFramework.Utils;

namespace Vk.TestFramework.PageObjects.Pages
{
    public class MyProfilePage : BasePage
    {
        public MyProfilePage(WebDriver driver) : base(driver){}

        private WebElement topProfileLink => new WebElement(driver, SearchStrategies.Id, "top_profile_link");
        private WebElement topProfileMenu => new WebElement(driver, SearchStrategies.Id, "top_profile_menu");
        private WebElement logOutLink => new WebElement(driver, SearchStrategies.Id, "top_logout_link");
        private WebElement uploadNewPhoto => new WebElement(driver, SearchStrategies.ByXPath, "//div[@id='owner_photo_input']/input");
        private WebElement uploadProfilePhotoLink => new WebElement(driver, SearchStrategies.Id, "page_load_photo");
        private WebElement pageAvatar => new WebElement(driver, SearchStrategies.Id, "page_avatar");
        private WebElement ownerPhoto => new WebElement(driver, SearchStrategies.Id, "owner_photo_img");
        private WebElement saveAndContinueButton => new WebElement(driver, SearchStrategies.Id, "owner_photo_done_edit");
        private WebElement savePhotoButton => new WebElement(driver, SearchStrategies.Id, "owner_photo_done");
        private WebElement pageAvatarWithImg => new WebElement(driver, SearchStrategies.ByXPath, "//img[@class='page_avatar_img']");

        public void VerifythatUserSuccessfullyLogIn()
        {
            Assert.IsTrue(topProfileLink.GetElement().Displayed);
        }

        public void ClickTopProfileLink() => topProfileLink.Click();
        public void ClickLogOutLink()
        {
            topProfileMenu.WaitElementIsVisible();
            logOutLink.Click();
        }

        public void ClickUploadProfilePhotoLink()
        {
            pageAvatar.WaitElementIsVisible();
            uploadProfilePhotoLink.Click();
        }

        public void UploadFile(string path)
        {
            CommonUtilities.UploadFile(uploadNewPhoto, CommonUtilities.GetPath(path));
        }

        public void VerifyOwnerPhotoIsDisplay()
        {
            Assert.IsTrue(ownerPhoto.GetElement().Displayed);
        }

        public void ClickSaveAndContinueButton() => saveAndContinueButton.Click();
        public void ClickSaveButton() => savePhotoButton.Click();
        public void VerifyUploadedAvatarIsDisplay() => Assert.IsTrue(pageAvatarWithImg.GetElement().Displayed);
    }
}
