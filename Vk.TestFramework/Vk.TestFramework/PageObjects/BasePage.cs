using CAD.CD.Search.TestFramework.Config;
using CAD.CD.Search.TestFramework.Driver;
using NLog;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CAD.CD.Search.TestFramework.PageObjects
{
    public class BasePage
    {
        //protected Logger logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

        protected WebDriver driver;

        protected DriverWaiters driverWaiters;

        protected Actions driverActions;

        public BasePage(WebDriver driver)
        {
            this.driver = driver;
            driverWaiters = new DriverWaiters();
            driverActions = new Actions(driver.Current);
        }

        protected void cleareInputField(IWebElement textfield)
        {
            textfield.SendKeys(Keys.Control + "a" + Keys.Delete);

        }

        protected void SetImplisitWait(int seconds)
        {
            driver.Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        protected void ResetImplisitWait()
        {
            int ImplicitWaitTimeout = ConfigLoader.LoadJson("testConfig").implicitWaitTimeout;
            driver.Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ImplicitWaitTimeout);
        }

        protected void ClickByElementCoordinates(IWebElement element)
        {
            driverActions.MoveToElement(element).MoveByOffset(0, 0).Click().Perform();
        }
    }
}
