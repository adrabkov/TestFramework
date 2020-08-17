using CAD.CD.Search.TestFramework.Driver;
using CAD.CD.Search.TestFramework.PageObjects;
using CAD.CD.Search.TestFramework.PageObjects.PageElements;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.TestFramework.PageObjects.Pages
{
    public class MyProfilePage : BasePage
    {
        public MyProfilePage(WebDriver driver) : base(driver){}

        private WebElement topProfileLink => new WebElement(driver, SearchStrategies.Id, "top_profile_link");
        private WebElement topProfileMenu => new WebElement(driver, SearchStrategies.Id, "top_profile_menu");
        private WebElement logOutLink => new WebElement(driver, SearchStrategies.Id, "top_logout_link");


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
    }
}
