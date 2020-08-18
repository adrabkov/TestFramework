using CAD.CD.Search.TestFramework.Driver;
using CAD.CD.Search.TestFramework.PageObjects;
using CAD.CD.Search.TestFramework.PageObjects.PageElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.TestFramework.PageObjects.Pages
{
    public class CommonPage : BasePage
    {
        public CommonPage(WebDriver driver) : base(driver) {}

        private WebElement MyProfileItem => new WebElement(driver, SearchStrategies.Id, "l_pr");
        private WebElement NewsItem => new WebElement(driver, SearchStrategies.Id, "l_nwsf");
        private WebElement MessagesItem => new WebElement(driver, SearchStrategies.Id, "l_msg");
        private WebElement FriendsItem => new WebElement(driver, SearchStrategies.Id, "l_fr");
        private WebElement CommunitiesItem => new WebElement(driver, SearchStrategies.Id, "l_gr");
        private WebElement PhotosItem => new WebElement(driver, SearchStrategies.Id, "l_ph");
        private WebElement MusicItem => new WebElement(driver, SearchStrategies.Id, "l_aud");
        private WebElement VideosItem => new WebElement(driver, SearchStrategies.Id, "l_vid");
        private WebElement GamesItem => new WebElement(driver, SearchStrategies.Id, "l_ap");

        public void ClickMyProfileItem() => MyProfileItem.Click();


    }
}
