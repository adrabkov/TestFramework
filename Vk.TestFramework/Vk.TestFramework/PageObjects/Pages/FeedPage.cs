using CAD.CD.Search.TestFramework.Driver;
using CAD.CD.Search.TestFramework.PageObjects;
using CAD.CD.Search.TestFramework.PageObjects.PageElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.TestFramework.PageObjects.Pages
{
    public class FeedPage: BasePage
    {
        public FeedPage(WebDriver driver) : base(driver)
        {
            MyProfile = new MyProfilePage(driver);
        }

        public MyProfilePage MyProfile { get; }

        private WebElement userNameInput => new WebElement(driver, SearchStrategies.Id, "index_email");

    }
}
